


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class EmotePlayAbstractMessage : NetworkMessage
{

public const uint Id = 1886;
public override uint MessageId
{
    get { return Id; }
}

public ushort emoteId;
        public double emoteStartTime;
        

public EmotePlayAbstractMessage()
{
}

public EmotePlayAbstractMessage(ushort emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUShort(emoteId);
            writer.WriteDouble(emoteStartTime);
            

}

public override void Deserialize(IDataReader reader)
{

emoteId = reader.ReadUShort();
            emoteStartTime = reader.ReadDouble();
            

}


}


}