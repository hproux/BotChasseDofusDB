


















// Generated on 02/22/2023 19:13:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyPledgeLoyaltyRequestMessage : AbstractPartyMessage
{

public const uint Id = 4327;
public override uint MessageId
{
    get { return Id; }
}

public bool loyal;
        

public PartyPledgeLoyaltyRequestMessage()
{
}

public PartyPledgeLoyaltyRequestMessage(uint partyId, bool loyal)
         : base(partyId)
        {
            this.loyal = loyal;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(loyal);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            loyal = reader.ReadBoolean();
            

}


}


}