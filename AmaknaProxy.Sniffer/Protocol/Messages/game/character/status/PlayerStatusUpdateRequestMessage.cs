


















// Generated on 02/22/2023 19:13:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PlayerStatusUpdateRequestMessage : NetworkMessage
{

public const uint Id = 6252;
public override uint MessageId
{
    get { return Id; }
}

public Types.PlayerStatus status;
        

public PlayerStatusUpdateRequestMessage()
{
}

public PlayerStatusUpdateRequestMessage(Types.PlayerStatus status)
        {
            this.status = status;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
            

}


}


}