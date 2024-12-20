


















// Generated on 02/22/2023 19:13:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ChatSmileyRequestMessage : NetworkMessage
{

public const uint Id = 5949;
public override uint MessageId
{
    get { return Id; }
}

public uint smileyId;
        

public ChatSmileyRequestMessage()
{
}

public ChatSmileyRequestMessage(uint smileyId)
        {
            this.smileyId = smileyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)smileyId);
            

}

public override void Deserialize(IDataReader reader)
{

smileyId = reader.ReadVarUhShort();
            

}


}


}