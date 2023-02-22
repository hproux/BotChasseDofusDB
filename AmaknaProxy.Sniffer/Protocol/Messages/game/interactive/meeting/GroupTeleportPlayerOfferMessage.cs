


















// Generated on 02/22/2023 19:13:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GroupTeleportPlayerOfferMessage : NetworkMessage
{

public const uint Id = 3021;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public short worldX;
        public short worldY;
        public uint timeLeft;
        public double requesterId;
        public string requesterName;
        

public GroupTeleportPlayerOfferMessage()
{
}

public GroupTeleportPlayerOfferMessage(double mapId, short worldX, short worldY, uint timeLeft, double requesterId, string requesterName)
        {
            this.mapId = mapId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.timeLeft = timeLeft;
            this.requesterId = requesterId;
            this.requesterName = requesterName;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteVarInt((int)timeLeft);
            writer.WriteVarLong(requesterId);
            writer.WriteUTF(requesterName);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            timeLeft = reader.ReadVarUhInt();
            requesterId = reader.ReadVarUhLong();
            requesterName = reader.ReadUTF();
            

}


}


}