


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeObjectMoveKamaMessage : NetworkMessage
{

public const uint Id = 1808;
public override uint MessageId
{
    get { return Id; }
}

public double quantity;
        

public ExchangeObjectMoveKamaMessage()
{
}

public ExchangeObjectMoveKamaMessage(double quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(quantity);
            

}

public override void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarLong();
            

}


}


}