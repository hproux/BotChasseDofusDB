


















// Generated on 02/17/2023 18:45:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameCautiousMapMovementMessage : GameMapMovementMessage
{

public const uint Id = 762;
public override uint MessageId
{
    get { return Id; }
}



public GameCautiousMapMovementMessage()
{
}

public GameCautiousMapMovementMessage(short[] keyMovements, short forcedDirection, double actorId)
         : base(keyMovements, forcedDirection, actorId)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}