


















// Generated on 02/22/2023 19:13:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildJoinAutomaticallyRequestMessage : NetworkMessage
{

public const uint Id = 7374;
public override uint MessageId
{
    get { return Id; }
}

public int guildId;
        

public GuildJoinAutomaticallyRequestMessage()
{
}

public GuildJoinAutomaticallyRequestMessage(int guildId)
        {
            this.guildId = guildId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(guildId);
            

}

public override void Deserialize(IDataReader reader)
{

guildId = reader.ReadInt();
            

}


}


}