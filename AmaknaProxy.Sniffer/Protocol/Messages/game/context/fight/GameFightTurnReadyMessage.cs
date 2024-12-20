


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightTurnReadyMessage : NetworkMessage
{

public const uint Id = 2472;
public override uint MessageId
{
    get { return Id; }
}

public bool isReady;
        

public GameFightTurnReadyMessage()
{
}

public GameFightTurnReadyMessage(bool isReady)
        {
            this.isReady = isReady;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isReady);
            

}

public override void Deserialize(IDataReader reader)
{

isReady = reader.ReadBoolean();
            

}


}


}