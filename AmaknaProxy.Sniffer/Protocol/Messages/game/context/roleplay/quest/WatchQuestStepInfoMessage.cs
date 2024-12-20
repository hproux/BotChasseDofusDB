


















// Generated on 02/22/2023 19:13:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class WatchQuestStepInfoMessage : QuestStepInfoMessage
{

public const uint Id = 673;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public WatchQuestStepInfoMessage()
{
}

public WatchQuestStepInfoMessage(Types.QuestActiveInformations infos, double playerId)
         : base(infos)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            

}


}


}