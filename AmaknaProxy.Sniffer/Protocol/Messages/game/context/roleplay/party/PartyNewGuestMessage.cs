


















// Generated on 02/22/2023 19:13:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyNewGuestMessage : AbstractPartyEventMessage
{

public const uint Id = 8314;
public override uint MessageId
{
    get { return Id; }
}

public Types.PartyGuestInformations guest;
        

public PartyNewGuestMessage()
{
}

public PartyNewGuestMessage(uint partyId, Types.PartyGuestInformations guest)
         : base(partyId)
        {
            this.guest = guest;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guest.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guest = new Types.PartyGuestInformations();
            guest.Deserialize(reader);
            

}


}


}