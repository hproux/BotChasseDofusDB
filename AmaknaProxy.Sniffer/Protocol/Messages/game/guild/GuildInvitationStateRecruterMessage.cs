


















// Generated on 02/22/2023 19:13:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildInvitationStateRecruterMessage : NetworkMessage
{

public const uint Id = 4630;
public override uint MessageId
{
    get { return Id; }
}

public string recrutedName;
        public sbyte invitationState;
        

public GuildInvitationStateRecruterMessage()
{
}

public GuildInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
        {
            this.recrutedName = recrutedName;
            this.invitationState = invitationState;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(recrutedName);
            writer.WriteSbyte(invitationState);
            

}

public override void Deserialize(IDataReader reader)
{

recrutedName = reader.ReadUTF();
            invitationState = reader.ReadSbyte();
            

}


}


}