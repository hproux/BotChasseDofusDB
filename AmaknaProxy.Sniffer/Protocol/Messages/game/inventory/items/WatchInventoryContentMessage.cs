


















// Generated on 02/17/2023 18:45:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class WatchInventoryContentMessage : InventoryContentMessage
{

public const uint Id = 974;
public override uint MessageId
{
    get { return Id; }
}



public WatchInventoryContentMessage()
{
}

public WatchInventoryContentMessage(Types.ObjectItem[] objects, double kamas)
         : base(objects, kamas)
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