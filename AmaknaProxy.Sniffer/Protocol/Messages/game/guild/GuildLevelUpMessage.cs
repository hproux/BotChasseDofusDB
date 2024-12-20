


















// Generated on 02/22/2023 19:13:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildLevelUpMessage : NetworkMessage
{

public const uint Id = 3746;
public override uint MessageId
{
    get { return Id; }
}

public byte newLevel;
        

public GuildLevelUpMessage()
{
}

public GuildLevelUpMessage(byte newLevel)
        {
            this.newLevel = newLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteByte(newLevel);
            

}

public override void Deserialize(IDataReader reader)
{

newLevel = reader.ReadByte();
            

}


}


}