


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class ObjectItemQuantity : Item
{

public const short Id = 8102;
public override short TypeId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        

public ObjectItemQuantity()
{
}

public ObjectItemQuantity(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}