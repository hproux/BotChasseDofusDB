


















// Generated on 02/22/2023 19:13:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildChestTabLastContributionMessage : NetworkMessage
{

public const uint Id = 2135;
public override uint MessageId
{
    get { return Id; }
}

public double lastContributionDate;
        

public GuildChestTabLastContributionMessage()
{
}

public GuildChestTabLastContributionMessage(double lastContributionDate)
        {
            this.lastContributionDate = lastContributionDate;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(lastContributionDate);
            

}

public override void Deserialize(IDataReader reader)
{

lastContributionDate = reader.ReadDouble();
            

}


}


}