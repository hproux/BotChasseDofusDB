


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayPlayerFightFriendlyAnsweredMessage : NetworkMessage
{

public const uint Id = 697;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public double sourceId;
        public double targetId;
        public bool accept;
        

public GameRolePlayPlayerFightFriendlyAnsweredMessage()
{
}

public GameRolePlayPlayerFightFriendlyAnsweredMessage(uint fightId, double sourceId, double targetId, bool accept)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
            this.accept = accept;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteVarLong(sourceId);
            writer.WriteVarLong(targetId);
            writer.WriteBoolean(accept);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            sourceId = reader.ReadVarUhLong();
            targetId = reader.ReadVarUhLong();
            accept = reader.ReadBoolean();
            

}


}


}