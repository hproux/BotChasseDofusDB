


















// Generated on 02/17/2023 18:45:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeCraftPaymentModificationRequestMessage : NetworkMessage
{

public const uint Id = 1214;
public override uint MessageId
{
    get { return Id; }
}

public double quantity;
        

public ExchangeCraftPaymentModificationRequestMessage()
{
}

public ExchangeCraftPaymentModificationRequestMessage(double quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(quantity);
            

}

public override void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarUhLong();
            

}


}


}