


















// Generated on 02/17/2023 18:45:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class DebtInformation
{

public const short Id = 2854;
public virtual short TypeId
{
    get { return Id; }
}

public double id;
        public double timestamp;
        

public DebtInformation()
{
}

public DebtInformation(double id, double timestamp)
        {
            this.id = id;
            this.timestamp = timestamp;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            writer.WriteDouble(timestamp);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            timestamp = reader.ReadDouble();
            

}


}


}