


















// Generated on 02/22/2023 19:13:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildFactsRequestMessage : NetworkMessage
{

public const uint Id = 1622;
public override uint MessageId
{
    get { return Id; }
}

public uint guildId;
        

public GuildFactsRequestMessage()
{
}

public GuildFactsRequestMessage(uint guildId)
        {
            this.guildId = guildId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildId);
            

}

public override void Deserialize(IDataReader reader)
{

guildId = reader.ReadVarUhInt();
            

}


}


}