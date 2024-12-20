


















// Generated on 02/22/2023 19:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class HaapiCancelBidRequestMessage : NetworkMessage
{

public const uint Id = 4878;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        public sbyte type;
        

public HaapiCancelBidRequestMessage()
{
}

public HaapiCancelBidRequestMessage(double id, sbyte type)
        {
            this.id = id;
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            type = reader.ReadSbyte();
            

}


}


}