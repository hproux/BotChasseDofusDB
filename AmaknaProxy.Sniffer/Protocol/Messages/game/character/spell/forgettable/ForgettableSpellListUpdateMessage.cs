


















// Generated on 02/22/2023 19:13:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ForgettableSpellListUpdateMessage : NetworkMessage
{

public const uint Id = 3380;
public override uint MessageId
{
    get { return Id; }
}

public sbyte action;
        public Types.ForgettableSpellItem[] spells;
        

public ForgettableSpellListUpdateMessage()
{
}

public ForgettableSpellListUpdateMessage(sbyte action, Types.ForgettableSpellItem[] spells)
        {
            this.action = action;
            this.spells = spells;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(action);
            writer.WriteShort((short)spells.Length);
            foreach (var entry in spells)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

action = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            spells = new Types.ForgettableSpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 spells[i] = new Types.ForgettableSpellItem();
                 spells[i].Deserialize(reader);
            }
            

}


}


}