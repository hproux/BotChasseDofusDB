


















// Generated on 02/22/2023 19:13:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class ServerSessionConstantInteger : ServerSessionConstant
{

public const short Id = 9099;
public override short TypeId
{
    get { return Id; }
}

public int value;
        

public ServerSessionConstantInteger()
{
}

public ServerSessionConstantInteger(uint id, int value)
         : base(id)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadInt();
            

}


}


}