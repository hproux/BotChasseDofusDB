


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GoldItem : Item
{

public const short Id = 7613;
public override short TypeId
{
    get { return Id; }
}

public double sum;
        

public GoldItem()
{
}

public GoldItem(double sum)
        {
            this.sum = sum;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(sum);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            sum = reader.ReadVarUhLong();
            

}


}


}