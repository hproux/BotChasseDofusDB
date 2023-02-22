


















// Generated on 02/22/2023 19:13:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyModifiableStatusMessage : AbstractPartyMessage
{

public const uint Id = 8345;
public override uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public PartyModifiableStatusMessage()
{
}

public PartyModifiableStatusMessage(uint partyId, bool enabled)
         : base(partyId)
        {
            this.enabled = enabled;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            enabled = reader.ReadBoolean();
            

}


}


}