


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class KamaDebtInformation : DebtInformation
{

public const short Id = 1295;
public override short TypeId
{
    get { return Id; }
}

public double kamas;
        

public KamaDebtInformation()
{
}

public KamaDebtInformation(double id, double timestamp, double kamas)
         : base(id, timestamp)
        {
            this.kamas = kamas;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(kamas);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            kamas = reader.ReadVarUhLong();
            

}


}


}