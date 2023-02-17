


















// Generated on 02/17/2023 18:45:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayArenaFighterStatusMessage : NetworkMessage
{

public const uint Id = 2258;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public double playerId;
        public bool accepted;
        

public GameRolePlayArenaFighterStatusMessage()
{
}

public GameRolePlayArenaFighterStatusMessage(uint fightId, double playerId, bool accepted)
        {
            this.fightId = fightId;
            this.playerId = playerId;
            this.accepted = accepted;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteVarLong(playerId);
            writer.WriteBoolean(accepted);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            playerId = reader.ReadVarUhLong();
            accepted = reader.ReadBoolean();
            

}


}


}