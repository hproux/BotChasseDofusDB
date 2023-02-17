


















// Generated on 02/17/2023 18:45:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class BasicTimeMessage : NetworkMessage
{

public const uint Id = 5815;
public override uint MessageId
{
    get { return Id; }
}

public double timestamp;
        public short timezoneOffset;
        

public BasicTimeMessage()
{
}

public BasicTimeMessage(double timestamp, short timezoneOffset)
        {
            this.timestamp = timestamp;
            this.timezoneOffset = timezoneOffset;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(timestamp);
            writer.WriteShort(timezoneOffset);
            

}

public override void Deserialize(IDataReader reader)
{

timestamp = reader.ReadDouble();
            timezoneOffset = reader.ReadShort();
            

}


}


}