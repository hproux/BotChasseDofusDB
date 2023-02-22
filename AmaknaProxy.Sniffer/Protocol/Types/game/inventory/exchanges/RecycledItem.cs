


















// Generated on 02/22/2023 19:13:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class RecycledItem
{

public const short Id = 3353;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public uint qty;
        

public RecycledItem()
{
}

public RecycledItem(uint id, uint qty)
        {
            this.id = id;
            this.qty = qty;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteUInt(qty);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            qty = reader.ReadUInt();
            

}


}


}