


















// Generated on 02/17/2023 18:45:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class QuestStepInfoRequestMessage : NetworkMessage
{

public const uint Id = 8458;
public override uint MessageId
{
    get { return Id; }
}

public uint questId;
        

public QuestStepInfoRequestMessage()
{
}

public QuestStepInfoRequestMessage(uint questId)
        {
            this.questId = questId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            

}

public override void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            

}


}


}