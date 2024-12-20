


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class CharacterMinimalPlusLookAndGradeInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 9686;
public override short TypeId
{
    get { return Id; }
}

public uint grade;
        

public CharacterMinimalPlusLookAndGradeInformations()
{
}

public CharacterMinimalPlusLookAndGradeInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, uint grade)
         : base(id, name, level, entityLook, breed)
        {
            this.grade = grade;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)grade);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            grade = reader.ReadVarUhInt();
            

}


}


}