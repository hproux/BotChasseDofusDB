


















// Generated on 02/22/2023 19:13:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GroupTeleportPlayerCloseMessage : NetworkMessage
{

public const uint Id = 4352;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public double requesterId;
        

public GroupTeleportPlayerCloseMessage()
{
}

public GroupTeleportPlayerCloseMessage(double mapId, double requesterId)
        {
            this.mapId = mapId;
            this.requesterId = requesterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteVarLong(requesterId);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            requesterId = reader.ReadVarUhLong();
            

}


}


}