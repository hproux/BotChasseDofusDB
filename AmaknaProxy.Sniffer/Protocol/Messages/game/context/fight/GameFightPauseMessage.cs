


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightPauseMessage : NetworkMessage
{

public const uint Id = 4482;
public override uint MessageId
{
    get { return Id; }
}

public bool isPaused;
        

public GameFightPauseMessage()
{
}

public GameFightPauseMessage(bool isPaused)
        {
            this.isPaused = isPaused;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isPaused);
            

}

public override void Deserialize(IDataReader reader)
{

isPaused = reader.ReadBoolean();
            

}


}


}