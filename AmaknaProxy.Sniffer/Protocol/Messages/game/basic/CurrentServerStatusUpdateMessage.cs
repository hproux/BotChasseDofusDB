


















// Generated on 02/22/2023 19:13:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CurrentServerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 8239;
public override uint MessageId
{
    get { return Id; }
}

public sbyte status;
        

public CurrentServerStatusUpdateMessage()
{
}

public CurrentServerStatusUpdateMessage(sbyte status)
        {
            this.status = status;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(status);
            

}

public override void Deserialize(IDataReader reader)
{

status = reader.ReadSbyte();
            

}


}


}