


















// Generated on 02/22/2023 19:13:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ChatAbstractClientMessage : NetworkMessage
{

public const uint Id = 7312;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        

public ChatAbstractClientMessage()
{
}

public ChatAbstractClientMessage(string content)
        {
            this.content = content;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            

}

public override void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            

}


}


}