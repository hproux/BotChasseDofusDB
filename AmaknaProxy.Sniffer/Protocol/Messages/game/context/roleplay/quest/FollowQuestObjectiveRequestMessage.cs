


















// Generated on 02/22/2023 19:13:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class FollowQuestObjectiveRequestMessage : NetworkMessage
{

public const uint Id = 2060;
public override uint MessageId
{
    get { return Id; }
}

public uint questId;
        public short objectiveId;
        

public FollowQuestObjectiveRequestMessage()
{
}

public FollowQuestObjectiveRequestMessage(uint questId, short objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            writer.WriteShort(objectiveId);
            

}

public override void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            objectiveId = reader.ReadShort();
            

}


}


}