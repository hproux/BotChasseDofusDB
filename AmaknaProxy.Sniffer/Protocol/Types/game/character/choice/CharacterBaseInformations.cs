


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 3972;
public override short TypeId
{
    get { return Id; }
}

public bool sex;
        

public CharacterBaseInformations()
{
}

public CharacterBaseInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, bool sex)
         : base(id, name, level, entityLook, breed)
        {
            this.sex = sex;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(sex);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            sex = reader.ReadBoolean();
            

}


}


}