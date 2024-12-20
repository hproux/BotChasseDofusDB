


















// Generated on 02/22/2023 19:13:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class DisplayNumericalValuePaddockMessage : NetworkMessage
{

public const uint Id = 4794;
public override uint MessageId
{
    get { return Id; }
}

public int rideId;
        public int value;
        public sbyte type;
        

public DisplayNumericalValuePaddockMessage()
{
}

public DisplayNumericalValuePaddockMessage(int rideId, int value, sbyte type)
        {
            this.rideId = rideId;
            this.value = value;
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(rideId);
            writer.WriteInt(value);
            writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

rideId = reader.ReadInt();
            value = reader.ReadInt();
            type = reader.ReadSbyte();
            

}


}


}