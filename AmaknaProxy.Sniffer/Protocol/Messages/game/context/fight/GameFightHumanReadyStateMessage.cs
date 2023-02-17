


















// Generated on 02/17/2023 18:45:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightHumanReadyStateMessage : NetworkMessage
{

public const uint Id = 6173;
public override uint MessageId
{
    get { return Id; }
}

public double characterId;
        public bool isReady;
        

public GameFightHumanReadyStateMessage()
{
}

public GameFightHumanReadyStateMessage(double characterId, bool isReady)
        {
            this.characterId = characterId;
            this.isReady = isReady;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            writer.WriteBoolean(isReady);
            

}

public override void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            isReady = reader.ReadBoolean();
            

}


}


}