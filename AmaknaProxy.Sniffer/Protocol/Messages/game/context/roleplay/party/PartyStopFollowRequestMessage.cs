


















// Generated on 02/22/2023 19:13:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyStopFollowRequestMessage : AbstractPartyMessage
{

public const uint Id = 4867;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public PartyStopFollowRequestMessage()
{
}

public PartyStopFollowRequestMessage(uint partyId, double playerId)
         : base(partyId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            

}


}


}