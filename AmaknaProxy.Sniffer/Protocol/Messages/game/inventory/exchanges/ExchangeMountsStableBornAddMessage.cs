


















// Generated on 02/22/2023 19:13:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeMountsStableBornAddMessage : ExchangeMountsStableAddMessage
{

public const uint Id = 7573;
public override uint MessageId
{
    get { return Id; }
}



public ExchangeMountsStableBornAddMessage()
{
}

public ExchangeMountsStableBornAddMessage(Types.MountClientData[] mountDescription)
         : base(mountDescription)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}