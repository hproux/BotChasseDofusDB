


















// Generated on 02/22/2023 19:13:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class FriendWarnOnLevelGainStateMessage : NetworkMessage
{

public const uint Id = 4114;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendWarnOnLevelGainStateMessage()
{
}

public FriendWarnOnLevelGainStateMessage(bool enable)
        {
            this.enable = enable;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public override void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}