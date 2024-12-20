


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MountEmoteIconUsedOkMessage : NetworkMessage
{

public const uint Id = 4509;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        public sbyte reactionType;
        

public MountEmoteIconUsedOkMessage()
{
}

public MountEmoteIconUsedOkMessage(int mountId, sbyte reactionType)
        {
            this.mountId = mountId;
            this.reactionType = reactionType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountId);
            writer.WriteSbyte(reactionType);
            

}

public override void Deserialize(IDataReader reader)
{

mountId = reader.ReadVarInt();
            reactionType = reader.ReadSbyte();
            

}


}


}