


















// Generated on 02/22/2023 19:13:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class HumanOptionObjectUse : HumanOption
{

public const short Id = 4121;
public override short TypeId
{
    get { return Id; }
}

public sbyte delayTypeId;
        public double delayEndTime;
        public uint objectGID;
        

public HumanOptionObjectUse()
{
}

public HumanOptionObjectUse(sbyte delayTypeId, double delayEndTime, uint objectGID)
        {
            this.delayTypeId = delayTypeId;
            this.delayEndTime = delayEndTime;
            this.objectGID = objectGID;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(delayTypeId);
            writer.WriteDouble(delayEndTime);
            writer.WriteVarInt((int)objectGID);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            delayTypeId = reader.ReadSbyte();
            delayEndTime = reader.ReadDouble();
            objectGID = reader.ReadVarUhInt();
            

}


}


}