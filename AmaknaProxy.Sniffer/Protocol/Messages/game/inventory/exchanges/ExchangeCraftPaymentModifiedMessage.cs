


















// Generated on 02/17/2023 18:45:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeCraftPaymentModifiedMessage : NetworkMessage
{

public const uint Id = 9672;
public override uint MessageId
{
    get { return Id; }
}

public double goldSum;
        

public ExchangeCraftPaymentModifiedMessage()
{
}

public ExchangeCraftPaymentModifiedMessage(double goldSum)
        {
            this.goldSum = goldSum;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(goldSum);
            

}

public override void Deserialize(IDataReader reader)
{

goldSum = reader.ReadVarUhLong();
            

}


}


}