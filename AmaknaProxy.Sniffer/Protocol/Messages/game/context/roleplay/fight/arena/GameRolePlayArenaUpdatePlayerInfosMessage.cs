


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayArenaUpdatePlayerInfosMessage : NetworkMessage
{

public const uint Id = 925;
public override uint MessageId
{
    get { return Id; }
}

public Types.ArenaRankInfos solo;
        

public GameRolePlayArenaUpdatePlayerInfosMessage()
{
}

public GameRolePlayArenaUpdatePlayerInfosMessage(Types.ArenaRankInfos solo)
        {
            this.solo = solo;
        }
        

public override void Serialize(IDataWriter writer)
{

solo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

solo = new Types.ArenaRankInfos();
            solo.Deserialize(reader);
            

}


}


}