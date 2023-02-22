


















// Generated on 02/22/2023 19:13:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class EmoteAddMessage : NetworkMessage
{

public const uint Id = 9636;
public override uint MessageId
{
    get { return Id; }
}

public ushort emoteId;
        

public EmoteAddMessage()
{
}

public EmoteAddMessage(ushort emoteId)
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