


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightPlacementSwapPositionsAcceptMessage : NetworkMessage
{

public const uint Id = 6235;
public override uint MessageId
{
    get { return Id; }
}

public int requestId;
        

public GameFightPlacementSwapPositionsAcceptMessage()
{
}

public GameFightPlacementSwapPositionsAcceptMessage(int requestId)
        {
            this.requestId = requestId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(requestId);
            

}

public override void Deserialize(IDataReader reader)
{

requestId = reader.ReadInt();
            

}


}


}