


















// Generated on 02/17/2023 18:45:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class LivingObjectChangeSkinRequestMessage : NetworkMessage
{

public const uint Id = 6916;
public override uint MessageId
{
    get { return Id; }
}

public uint livingUID;
        public byte livingPosition;
        public uint skinId;
        

public LivingObjectChangeSkinRequestMessage()
{
}

public LivingObjectChangeSkinRequestMessage(uint livingUID, byte livingPosition, uint skinId)
        {
            this.livingUID = livingUID;
            this.livingPosition = livingPosition;
            this.skinId = skinId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)livingUID);
            writer.WriteByte(livingPosition);
            writer.WriteVarInt((int)skinId);
            

}

public override void Deserialize(IDataReader reader)
{

livingUID = reader.ReadVarUhInt();
            livingPosition = reader.ReadByte();
            skinId = reader.ReadVarUhInt();
            

}


}


}