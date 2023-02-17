﻿using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AmaknaProxy.API.Extensions.Reflection;
using AmaknaProxy.API.Managers;

namespace AmaknaProxy.API.Protocol
{
    public static class MessageReceiver
    {

        #region Variables

        private static readonly Dictionary<uint, Func<NetworkMessage>> m_constructors = new Dictionary<uint, Func<NetworkMessage>>(800);
        private static readonly Dictionary<uint, Type> m_messages = new Dictionary<uint, Type>(800);

        #endregion

        #region Methods

        public static NetworkMessage BuildMessage(uint id, IDataReader reader)
        {
            try
            {
                if (!m_messages.ContainsKey(id))
                    throw new MessageNotFoundException(string.Format("NetworkMessage <id:{0}> no existe", id));

                NetworkMessage message = m_constructors[id]();

                if (message == null)
                    throw new MessageNotFoundException(string.Format("Constructor[{0}] (delegate {1}) unknown", id, m_messages[id]));

                try
                {
                    message.Unpack(reader);
                }
                catch (Exception ex)
                {
                    ConsoleManager.Error(string.Format("Impossible de désérialiser le message pour l'id {0} ({1}).", id, ex.Message));
                    return message;
                }

                return message;
            }
            catch(Exception ex)
            {
                ConsoleManager.Error(string.Format("Impossible de créer un message pour l'id {0} ({1}).", id, ex.Message));
                return null;
            }
        }

        public static void Initialize()
        {
            Assembly asm = Assembly.GetAssembly(typeof(MessageReceiver));

            foreach (Type type in asm.GetTypes())
            {
                if (!type.IsSubclassOf(typeof(NetworkMessage)))
                    continue;

                FieldInfo fieldId = type.GetField("Id");

                if (fieldId != null)
                {
                    uint id = (uint)fieldId.GetValue(type);
                    if (m_messages.ContainsKey(id))
                        throw new AmbiguousMatchException(
                            string.Format(
                                "MessageReceiver() => {0} l'élément est déjà dans le dictionnaire, l'ancien type est : {1}, le nouveau type est {2}",
                                id, m_messages[id], type));

                    m_messages.Add(id, type);

                    ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);

                    if (ctor == null)
                        throw new System.Exception(
                            string.Format("'{0}' n'implemente pas de constructeur sans paramètres",
                                          type));

                    m_constructors.Add(id, ctor.CreateDelegate<Func<NetworkMessage>>());
                }
            }
        }

        public static Type GetMessageType(uint id)
        {
            if (!m_messages.ContainsKey(id))
                throw new MessageNotFoundException(string.Format("NetworkMessage <id:{0}> inconnu", id));

            return m_messages[id];
        }

        #endregion

        #region Nested type: MessageNotFoundException

        [Serializable]
        public class MessageNotFoundException : System.Exception
        {
            public MessageNotFoundException()
            {
            }

            public MessageNotFoundException(string message)
                : base(message)
            {
            }

            public MessageNotFoundException(string message, System.Exception inner)
                : base(message, inner)
            {
            }

            protected MessageNotFoundException(
                SerializationInfo info,
                StreamingContext context)
                : base(info, context)
            {
            }
        }

        #endregion

    }
}
