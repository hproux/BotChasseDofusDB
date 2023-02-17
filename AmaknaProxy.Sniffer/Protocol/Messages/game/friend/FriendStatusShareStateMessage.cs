


















// Generated on 02/17/2023 18:45:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class FriendStatusShareStateMessage : NetworkMessage
{

public const uint Id = 9395;
public override uint MessageId
{
    get { return Id; }
}

public bool share;
        

public FriendStatusShareStateMessage()
{
}

public FriendStatusShareStateMessage(bool share)
        {
            this.share = share;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(share);
            

}

public override void Deserialize(IDataReader reader)
{

share = reader.ReadBoolean();
            

}


}


}