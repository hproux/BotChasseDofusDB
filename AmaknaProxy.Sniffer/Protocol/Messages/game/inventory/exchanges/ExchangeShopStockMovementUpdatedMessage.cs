


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeShopStockMovementUpdatedMessage : NetworkMessage
{

public const uint Id = 9464;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemToSell objectInfo;
        

public ExchangeShopStockMovementUpdatedMessage()
{
}

public ExchangeShopStockMovementUpdatedMessage(Types.ObjectItemToSell objectInfo)
        {
            this.objectInfo = objectInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

objectInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

objectInfo = new Types.ObjectItemToSell();
            objectInfo.Deserialize(reader);
            

}


}


}