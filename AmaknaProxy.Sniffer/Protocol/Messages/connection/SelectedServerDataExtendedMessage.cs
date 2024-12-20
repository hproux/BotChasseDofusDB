


















// Generated on 02/22/2023 19:13:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
{

public const uint Id = 9230;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations[] servers;
        

public SelectedServerDataExtendedMessage()
{
}

public SelectedServerDataExtendedMessage(uint serverId, string address, uint[] ports, bool canCreateNewCharacter, sbyte[] ticket, Types.GameServerInformations[] servers)
         : base(serverId, address, ports, canCreateNewCharacter, ticket)
        {
            this.servers = servers;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)servers.Length);
            foreach (var entry in servers)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            servers = new Types.GameServerInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = new Types.GameServerInformations();
                 servers[i].Deserialize(reader);
            }
            

}


}


}