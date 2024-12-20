


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class ObjectEffectMinMax : ObjectEffect
{

public const short Id = 8669;
public override short TypeId
{
    get { return Id; }
}

public uint min;
        public uint max;
        

public ObjectEffectMinMax()
{
}

public ObjectEffectMinMax(uint actionId, uint min, uint max)
         : base(actionId)
        {
            this.min = min;
            this.max = max;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)min);
            writer.WriteVarInt((int)max);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            min = reader.ReadVarUhInt();
            max = reader.ReadVarUhInt();
            

}


}


}