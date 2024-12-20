


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AchievementDetailsMessage : NetworkMessage
{

public const uint Id = 983;
public override uint MessageId
{
    get { return Id; }
}

public Types.Achievement achievement;
        

public AchievementDetailsMessage()
{
}

public AchievementDetailsMessage(Types.Achievement achievement)
        {
            this.achievement = achievement;
        }
        

public override void Serialize(IDataWriter writer)
{

achievement.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

achievement = new Types.Achievement();
            achievement.Deserialize(reader);
            

}


}


}