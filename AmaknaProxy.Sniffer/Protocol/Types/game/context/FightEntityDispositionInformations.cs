


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class FightEntityDispositionInformations : EntityDispositionInformations
{

public const short Id = 1876;
public override short TypeId
{
    get { return Id; }
}

public double carryingCharacterId;
        

public FightEntityDispositionInformations()
{
}

public FightEntityDispositionInformations(short cellId, sbyte direction, double carryingCharacterId)
         : base(cellId, direction)
        {
            this.carryingCharacterId = carryingCharacterId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(carryingCharacterId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            carryingCharacterId = reader.ReadDouble();
            

}


}


}