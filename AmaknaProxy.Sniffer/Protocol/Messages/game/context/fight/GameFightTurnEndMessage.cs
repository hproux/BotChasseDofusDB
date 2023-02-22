


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightTurnEndMessage : NetworkMessage
{

public const uint Id = 3224;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        

public GameFightTurnEndMessage()
{
}

public GameFightTurnEndMessage(double id)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            

}


}


}