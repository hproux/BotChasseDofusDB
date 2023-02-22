


















// Generated on 02/22/2023 19:13:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class StatisticDataByte : StatisticData
{

public const short Id = 8126;
public override short TypeId
{
    get { return Id; }
}

public sbyte value;
        

public StatisticDataByte()
{
}

public StatisticDataByte(sbyte value)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadSbyte();
            

}


}


}