


















// Generated on 02/22/2023 19:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AccountSubscriptionElapsedDurationMessage : NetworkMessage
{

public const uint Id = 3364;
public override uint MessageId
{
    get { return Id; }
}

public double subscriptionElapsedDuration;
        

public AccountSubscriptionElapsedDurationMessage()
{
}

public AccountSubscriptionElapsedDurationMessage(double subscriptionElapsedDuration)
        {
            this.subscriptionElapsedDuration = subscriptionElapsedDuration;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(subscriptionElapsedDuration);
            

}

public override void Deserialize(IDataReader reader)
{

subscriptionElapsedDuration = reader.ReadDouble();
            

}


}


}