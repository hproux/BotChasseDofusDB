


















// Generated on 02/22/2023 19:13:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class IdolPartyRefreshMessage : NetworkMessage
{

public const uint Id = 1683;
public override uint MessageId
{
    get { return Id; }
}

public Types.PartyIdol partyIdol;
        

public IdolPartyRefreshMessage()
{
}

public IdolPartyRefreshMessage(Types.PartyIdol partyIdol)
        {
            this.partyIdol = partyIdol;
        }
        

public override void Serialize(IDataWriter writer)
{

partyIdol.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

partyIdol = new Types.PartyIdol();
            partyIdol.Deserialize(reader);
            

}


}


}