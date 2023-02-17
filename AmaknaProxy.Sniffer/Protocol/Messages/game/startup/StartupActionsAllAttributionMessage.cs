


















// Generated on 02/17/2023 18:45:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class StartupActionsAllAttributionMessage : NetworkMessage
{

public const uint Id = 5005;
public override uint MessageId
{
    get { return Id; }
}

public double characterId;
        

public StartupActionsAllAttributionMessage()
{
}

public StartupActionsAllAttributionMessage(double characterId)
        {
            this.characterId = characterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            

}

public override void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            

}


}


}