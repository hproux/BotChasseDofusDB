


















// Generated on 02/22/2023 19:13:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CharacterStatsListMessage : NetworkMessage
{

public const uint Id = 1106;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterCharacteristicsInformations stats;
        

public CharacterStatsListMessage()
{
}

public CharacterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;
        }
        

public override void Serialize(IDataWriter writer)
{

stats.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

stats = new Types.CharacterCharacteristicsInformations();
            stats.Deserialize(reader);
            

}


}


}