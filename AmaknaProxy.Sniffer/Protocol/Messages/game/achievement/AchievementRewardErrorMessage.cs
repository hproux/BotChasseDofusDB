


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AchievementRewardErrorMessage : NetworkMessage
{

public const uint Id = 7498;
public override uint MessageId
{
    get { return Id; }
}

public short achievementId;
        

public AchievementRewardErrorMessage()
{
}

public AchievementRewardErrorMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(achievementId);
            

}

public override void Deserialize(IDataReader reader)
{

achievementId = reader.ReadShort();
            

}


}


}