


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class EmotePlayErrorMessage : NetworkMessage
{

public const uint Id = 7214;
public override uint MessageId
{
    get { return Id; }
}

public ushort emoteId;
        

public EmotePlayErrorMessage()
{
}

public EmotePlayErrorMessage(ushort emoteId)
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