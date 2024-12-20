


















// Generated on 02/22/2023 19:13:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TeleportHavenBagAnswerMessage : NetworkMessage
{

public const uint Id = 9460;
public override uint MessageId
{
    get { return Id; }
}

public bool accept;
        

public TeleportHavenBagAnswerMessage()
{
}

public TeleportHavenBagAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accept);
            

}

public override void Deserialize(IDataReader reader)
{

accept = reader.ReadBoolean();
            

}


}


}