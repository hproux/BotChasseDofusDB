


















// Generated on 02/17/2023 18:45:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class ObjectItemInRolePlay
{

public const short Id = 7139;
public virtual short TypeId
{
    get { return Id; }
}

public uint cellId;
        public uint objectGID;
        

public ObjectItemInRolePlay()
{
}

public ObjectItemInRolePlay(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteVarInt((int)objectGID);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            objectGID = reader.ReadVarUhInt();
            

}


}


}