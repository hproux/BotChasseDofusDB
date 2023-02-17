


















// Generated on 02/17/2023 18:45:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class FightLootObject
{

public const short Id = 1928;
public virtual short TypeId
{
    get { return Id; }
}

public int objectId;
        public int quantity;
        public int priorityHint;
        

public FightLootObject()
{
}

public FightLootObject(int objectId, int quantity, int priorityHint)
        {
            this.objectId = objectId;
            this.quantity = quantity;
            this.priorityHint = priorityHint;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(objectId);
            writer.WriteInt(quantity);
            writer.WriteInt(priorityHint);
            

}

public virtual void Deserialize(IDataReader reader)
{

objectId = reader.ReadInt();
            quantity = reader.ReadInt();
            priorityHint = reader.ReadInt();
            

}


}


}