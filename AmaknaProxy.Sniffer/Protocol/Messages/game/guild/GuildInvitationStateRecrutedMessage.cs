


















// Generated on 02/22/2023 19:13:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildInvitationStateRecrutedMessage : NetworkMessage
{

public const uint Id = 7992;
public override uint MessageId
{
    get { return Id; }
}

public sbyte invitationState;
        

public GuildInvitationStateRecrutedMessage()
{
}

public GuildInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(invitationState);
            

}

public override void Deserialize(IDataReader reader)
{

invitationState = reader.ReadSbyte();
            

}


}


}