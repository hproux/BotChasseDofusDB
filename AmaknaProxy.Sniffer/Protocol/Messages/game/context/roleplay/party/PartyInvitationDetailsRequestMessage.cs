


















// Generated on 02/22/2023 19:13:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyInvitationDetailsRequestMessage : AbstractPartyMessage
{

public const uint Id = 9381;
public override uint MessageId
{
    get { return Id; }
}



public PartyInvitationDetailsRequestMessage()
{
}

public PartyInvitationDetailsRequestMessage(uint partyId)
         : base(partyId)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}