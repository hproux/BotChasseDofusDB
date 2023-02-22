


















// Generated on 02/22/2023 19:13:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GroupTeleportPlayerAnswerMessage : NetworkMessage
{

public const uint Id = 6708;
public override uint MessageId
{
    get { return Id; }
}

public bool accept;
        public double requesterId;
        

public GroupTeleportPlayerAnswerMessage()
{
}

public GroupTeleportPlayerAnswerMessage(bool accept, double requesterId)
        {
            this.accept = accept;
            this.requesterId = requesterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accept);
            writer.WriteVarLong(requesterId);
            

}

public override void Deserialize(IDataReader reader)
{

accept = reader.ReadBoolean();
            requesterId = reader.ReadVarUhLong();
            

}


}


}