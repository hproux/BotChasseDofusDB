


















// Generated on 02/17/2023 18:45:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class HavenBagFurnitureInformation
{

public const short Id = 1499;
public virtual short TypeId
{
    get { return Id; }
}

public uint cellId;
        public int funitureId;
        public sbyte orientation;
        

public HavenBagFurnitureInformation()
{
}

public HavenBagFurnitureInformation(uint cellId, int funitureId, sbyte orientation)
        {
            this.cellId = cellId;
            this.funitureId = funitureId;
            this.orientation = orientation;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteInt(funitureId);
            writer.WriteSbyte(orientation);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            funitureId = reader.ReadInt();
            orientation = reader.ReadSbyte();
            

}


}


}