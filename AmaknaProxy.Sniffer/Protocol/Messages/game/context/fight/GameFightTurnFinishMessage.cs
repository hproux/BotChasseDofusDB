


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightTurnFinishMessage : NetworkMessage
{

public const uint Id = 703;
public override uint MessageId
{
    get { return Id; }
}

public bool isAfk;
        

public GameFightTurnFinishMessage()
{
}

public GameFightTurnFinishMessage(bool isAfk)
        {
            this.isAfk = isAfk;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isAfk);
            

}

public override void Deserialize(IDataReader reader)
{

isAfk = reader.ReadBoolean();
            

}


}


}