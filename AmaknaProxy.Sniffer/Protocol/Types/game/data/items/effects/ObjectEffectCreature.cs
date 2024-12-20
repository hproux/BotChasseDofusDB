


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class ObjectEffectCreature : ObjectEffect
{

public const short Id = 2792;
public override short TypeId
{
    get { return Id; }
}

public uint monsterFamilyId;
        

public ObjectEffectCreature()
{
}

public ObjectEffectCreature(uint actionId, uint monsterFamilyId)
         : base(actionId)
        {
            this.monsterFamilyId = monsterFamilyId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)monsterFamilyId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            monsterFamilyId = reader.ReadVarUhShort();
            

}


}


}