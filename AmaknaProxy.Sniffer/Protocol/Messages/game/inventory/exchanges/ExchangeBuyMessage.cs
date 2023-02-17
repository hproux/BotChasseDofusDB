


















// Generated on 02/17/2023 18:45:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeBuyMessage : NetworkMessage
{

public const uint Id = 3840;
public override uint MessageId
{
    get { return Id; }
}

public uint objectToBuyId;
        public uint quantity;
        

public ExchangeBuyMessage()
{
}

public ExchangeBuyMessage(uint objectToBuyId, uint quantity)
        {
            this.objectToBuyId = objectToBuyId;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectToBuyId);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

objectToBuyId = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}