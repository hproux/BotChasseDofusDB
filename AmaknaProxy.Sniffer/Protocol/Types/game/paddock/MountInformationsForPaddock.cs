


















// Generated on 02/22/2023 19:13:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class MountInformationsForPaddock
{

public const short Id = 8850;
public virtual short TypeId
{
    get { return Id; }
}

public uint modelId;
        public string name;
        public string ownerName;
        

public MountInformationsForPaddock()
{
}

public MountInformationsForPaddock(uint modelId, string name, string ownerName)
        {
            this.modelId = modelId;
            this.name = name;
            this.ownerName = ownerName;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)modelId);
            writer.WriteUTF(name);
            writer.WriteUTF(ownerName);
            

}

public virtual void Deserialize(IDataReader reader)
{

modelId = reader.ReadVarUhShort();
            name = reader.ReadUTF();
            ownerName = reader.ReadUTF();
            

}


}


}