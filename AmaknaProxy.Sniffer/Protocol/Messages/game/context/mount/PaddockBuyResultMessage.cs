


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PaddockBuyResultMessage : NetworkMessage
{

public const uint Id = 7045;
public override uint MessageId
{
    get { return Id; }
}

public double paddockId;
        public bool bought;
        public double realPrice;
        

public PaddockBuyResultMessage()
{
}

public PaddockBuyResultMessage(double paddockId, bool bought, double realPrice)
        {
            this.paddockId = paddockId;
            this.bought = bought;
            this.realPrice = realPrice;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(paddockId);
            writer.WriteBoolean(bought);
            writer.WriteVarLong(realPrice);
            

}

public override void Deserialize(IDataReader reader)
{

paddockId = reader.ReadDouble();
            bought = reader.ReadBoolean();
            realPrice = reader.ReadVarUhLong();
            

}


}


}