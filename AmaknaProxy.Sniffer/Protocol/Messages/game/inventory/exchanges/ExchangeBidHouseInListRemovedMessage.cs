


















// Generated on 02/22/2023 19:13:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
{

public const uint Id = 531;
public override uint MessageId
{
    get { return Id; }
}

public int itemUID;
        public uint objectGID;
        public int objectType;
        

public ExchangeBidHouseInListRemovedMessage()
{
}

public ExchangeBidHouseInListRemovedMessage(int itemUID, uint objectGID, int objectType)
        {
            this.itemUID = itemUID;
            this.objectGID = objectGID;
            this.objectType = objectType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(itemUID);
            writer.WriteVarInt((int)objectGID);
            writer.WriteInt(objectType);
            

}

public override void Deserialize(IDataReader reader)
{

itemUID = reader.ReadInt();
            objectGID = reader.ReadVarUhInt();
            objectType = reader.ReadInt();
            

}


}


}