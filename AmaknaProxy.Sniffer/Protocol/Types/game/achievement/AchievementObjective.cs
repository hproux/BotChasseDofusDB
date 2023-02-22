


















// Generated on 02/22/2023 19:13:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class AchievementObjective
{

public const short Id = 4324;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public uint maxValue;
        

public AchievementObjective()
{
}

public AchievementObjective(uint id, uint maxValue)
        {
            this.id = id;
            this.maxValue = maxValue;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteVarShort((int)maxValue);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            maxValue = reader.ReadVarUhShort();
            

}


}


}