


















// Generated on 02/22/2023 19:13:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class HumanOptionSpeedMultiplier : HumanOption
{

public const short Id = 5081;
public override short TypeId
{
    get { return Id; }
}

public uint speedMultiplier;
        

public HumanOptionSpeedMultiplier()
{
}

public HumanOptionSpeedMultiplier(uint speedMultiplier)
        {
            this.speedMultiplier = speedMultiplier;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)speedMultiplier);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            speedMultiplier = reader.ReadVarUhInt();
            

}


}


}