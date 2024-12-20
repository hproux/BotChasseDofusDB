


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayMonsterNotAngryAtPlayerMessage : NetworkMessage
{

public const uint Id = 2005;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        public double monsterGroupId;
        

public GameRolePlayMonsterNotAngryAtPlayerMessage()
{
}

public GameRolePlayMonsterNotAngryAtPlayerMessage(double playerId, double monsterGroupId)
        {
            this.playerId = playerId;
            this.monsterGroupId = monsterGroupId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteDouble(monsterGroupId);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            monsterGroupId = reader.ReadDouble();
            

}


}


}