


















// Generated on 02/22/2023 19:13:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class SkillActionDescriptionTimed : SkillActionDescription
{

public const short Id = 4372;
public override short TypeId
{
    get { return Id; }
}

public byte time;
        

public SkillActionDescriptionTimed()
{
}

public SkillActionDescriptionTimed(uint skillId, byte time)
         : base(skillId)
        {
            this.time = time;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(time);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            time = reader.ReadByte();
            

}


}


}