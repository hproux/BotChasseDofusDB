


















// Generated on 02/22/2023 19:13:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class QuestStartedMessage : NetworkMessage
{

public const uint Id = 9791;
public override uint MessageId
{
    get { return Id; }
}

public uint questId;
        

public QuestStartedMessage()
{
}

public QuestStartedMessage(uint questId)
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