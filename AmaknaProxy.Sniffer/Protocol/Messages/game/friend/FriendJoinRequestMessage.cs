


















// Generated on 02/22/2023 19:13:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class FriendJoinRequestMessage : NetworkMessage
{

public const uint Id = 2732;
public override uint MessageId
{
    get { return Id; }
}

public Types.AbstractPlayerSearchInformation target;
        

public FriendJoinRequestMessage()
{
}

public FriendJoinRequestMessage(Types.AbstractPlayerSearchInformation target)
        {
            this.target = target;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            

}


}


}