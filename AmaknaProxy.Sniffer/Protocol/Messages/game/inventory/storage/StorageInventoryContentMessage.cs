


















// Generated on 02/22/2023 19:13:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class StorageInventoryContentMessage : InventoryContentMessage
{

public const uint Id = 677;
public override uint MessageId
{
    get { return Id; }
}



public StorageInventoryContentMessage()
{
}

public StorageInventoryContentMessage(Types.ObjectItem[] objects, double kamas)
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