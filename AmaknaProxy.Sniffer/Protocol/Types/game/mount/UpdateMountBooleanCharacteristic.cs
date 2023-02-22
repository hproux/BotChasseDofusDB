


















// Generated on 02/22/2023 19:13:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class UpdateMountBooleanCharacteristic : UpdateMountCharacteristic
{

public const short Id = 1498;
public override short TypeId
{
    get { return Id; }
}

public bool value;
        

public UpdateMountBooleanCharacteristic()
{
}

public UpdateMountBooleanCharacteristic(sbyte type, bool value)
         : base(type)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadBoolean();
            

}


}


}