


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeObjectMoveMessage : NetworkMessage
{

public const uint Id = 6501;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public int quantity;
        

public ExchangeObjectMoveMessage()
{
}

public ExchangeObjectMoveMessage(uint objectUID, int quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarInt();
            

}


}


}