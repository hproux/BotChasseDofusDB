


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MountFeedRequestMessage : NetworkMessage
{

public const uint Id = 6428;
public override uint MessageId
{
    get { return Id; }
}

public uint mountUid;
        public sbyte mountLocation;
        public uint mountFoodUid;
        public uint quantity;
        

public MountFeedRequestMessage()
{
}

public MountFeedRequestMessage(uint mountUid, sbyte mountLocation, uint mountFoodUid, uint quantity)
        {
            this.mountUid = mountUid;
            this.mountLocation = mountLocation;
            this.mountFoodUid = mountFoodUid;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountUid);
            writer.WriteSbyte(mountLocation);
            writer.WriteVarInt((int)mountFoodUid);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

mountUid = reader.ReadVarUhInt();
            mountLocation = reader.ReadSbyte();
            mountFoodUid = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}