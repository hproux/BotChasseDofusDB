


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class EmotePlayRequestMessage : NetworkMessage
{

public const uint Id = 6115;
public override uint MessageId
{
    get { return Id; }
}

public ushort emoteId;
        

public EmotePlayRequestMessage()
{
}

public EmotePlayRequestMessage(ushort emoteId)
        {
            this.emoteId = emoteId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUShort(emoteId);
            

}

public override void Deserialize(IDataReader reader)
{

emoteId = reader.ReadUShort();
            

}


}


}