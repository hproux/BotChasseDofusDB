


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class HavenBagDailyLoteryMessage : NetworkMessage
{

public const uint Id = 3458;
public override uint MessageId
{
    get { return Id; }
}

public string gameActionId;
        

public HavenBagDailyLoteryMessage()
{
}

public HavenBagDailyLoteryMessage(string gameActionId)
        {
            this.gameActionId = gameActionId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(gameActionId);
            

}

public override void Deserialize(IDataReader reader)
{

gameActionId = reader.ReadUTF();
            

}


}


}