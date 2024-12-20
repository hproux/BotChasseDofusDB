


















// Generated on 02/22/2023 19:13:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameContextMoveElementMessage : NetworkMessage
{

public const uint Id = 8956;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityMovementInformations movement;
        

public GameContextMoveElementMessage()
{
}

public GameContextMoveElementMessage(Types.EntityMovementInformations movement)
        {
            this.movement = movement;
        }
        

public override void Serialize(IDataWriter writer)
{

movement.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

movement = new Types.EntityMovementInformations();
            movement.Deserialize(reader);
            

}


}


}