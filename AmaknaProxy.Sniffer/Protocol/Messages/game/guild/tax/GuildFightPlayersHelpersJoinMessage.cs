


















// Generated on 02/17/2023 18:45:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildFightPlayersHelpersJoinMessage : NetworkMessage
{

public const uint Id = 5728;
public override uint MessageId
{
    get { return Id; }
}

public double fightId;
        public Types.CharacterMinimalPlusLookInformations playerInfo;
        

public GuildFightPlayersHelpersJoinMessage()
{
}

public GuildFightPlayersHelpersJoinMessage(double fightId, Types.CharacterMinimalPlusLookInformations playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(fightId);
            playerInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadDouble();
            playerInfo = new Types.CharacterMinimalPlusLookInformations();
            playerInfo.Deserialize(reader);
            

}


}


}