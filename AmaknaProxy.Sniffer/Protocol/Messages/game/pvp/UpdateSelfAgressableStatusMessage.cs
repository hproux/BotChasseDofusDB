


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class UpdateSelfAgressableStatusMessage : NetworkMessage
{

public const uint Id = 9898;
public override uint MessageId
{
    get { return Id; }
}

public sbyte status;
        public int probationTime;
        

public UpdateSelfAgressableStatusMessage()
{
}

public UpdateSelfAgressableStatusMessage(sbyte status, int probationTime)
        {
            this.status = status;
            this.probationTime = probationTime;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(status);
            writer.WriteInt(probationTime);
            

}

public override void Deserialize(IDataReader reader)
{

status = reader.ReadSbyte();
            probationTime = reader.ReadInt();
            

}


}


}