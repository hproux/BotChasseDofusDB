


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class EntityDispositionInformations
{

public const short Id = 6822;
public virtual short TypeId
{
    get { return Id; }
}

public short cellId;
        public sbyte direction;
        

public EntityDispositionInformations()
{
}

public EntityDispositionInformations(short cellId, sbyte direction)
        {
            this.cellId = cellId;
            this.direction = direction;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(cellId);
            writer.WriteSbyte(direction);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadShort();
            direction = reader.ReadSbyte();
            

}


}


}