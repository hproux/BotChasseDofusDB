


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage
{

public const uint Id = 1680;
public override uint MessageId
{
    get { return Id; }
}

public double price;
        

public ExchangeObjectMovePricedMessage()
{
}

public ExchangeObjectMovePricedMessage(uint objectUID, int quantity, double price)
         : base(objectUID, quantity)
        {
            this.price = price;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(price);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            price = reader.ReadVarUhLong();
            

}


}


}