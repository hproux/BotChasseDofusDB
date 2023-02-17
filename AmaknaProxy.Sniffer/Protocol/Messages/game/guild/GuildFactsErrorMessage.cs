


















// Generated on 02/17/2023 18:45:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildFactsErrorMessage : NetworkMessage
{

public const uint Id = 9253;
public override uint MessageId
{
    get { return Id; }
}

public uint guildId;
        

public GuildFactsErrorMessage()
{
}

public GuildFactsErrorMessage(uint guildId)
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