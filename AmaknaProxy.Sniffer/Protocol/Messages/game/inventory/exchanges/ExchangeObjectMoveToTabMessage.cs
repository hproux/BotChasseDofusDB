


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeObjectMoveToTabMessage : NetworkMessage
{

public const uint Id = 7034;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public int quantity;
        public uint tabNumber;
        

public ExchangeObjectMoveToTabMessage()
{
}

public ExchangeObjectMoveToTabMessage(uint objectUID, int quantity, uint tabNumber)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.tabNumber = tabNumber;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            writer.WriteVarInt((int)tabNumber);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarInt();
            tabNumber = reader.ReadVarUhInt();
            

}


}


}