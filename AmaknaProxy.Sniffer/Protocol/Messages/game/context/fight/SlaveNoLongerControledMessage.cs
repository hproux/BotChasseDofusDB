


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class SlaveNoLongerControledMessage : NetworkMessage
{

public const uint Id = 4651;
public override uint MessageId
{
    get { return Id; }
}

public double masterId;
        public double slaveId;
        

public SlaveNoLongerControledMessage()
{
}

public SlaveNoLongerControledMessage(double masterId, double slaveId)
        {
            this.masterId = masterId;
            this.slaveId = slaveId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(masterId);
            writer.WriteDouble(slaveId);
            

}

public override void Deserialize(IDataReader reader)
{

masterId = reader.ReadDouble();
            slaveId = reader.ReadDouble();
            

}


}


}