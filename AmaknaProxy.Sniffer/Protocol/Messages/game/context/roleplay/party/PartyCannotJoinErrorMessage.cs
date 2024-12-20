


















// Generated on 02/22/2023 19:13:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyCannotJoinErrorMessage : AbstractPartyMessage
{

public const uint Id = 8151;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public PartyCannotJoinErrorMessage()
{
}

public PartyCannotJoinErrorMessage(uint partyId, sbyte reason)
         : base(partyId)
        {
            this.reason = reason;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(reason);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            reason = reader.ReadSbyte();
            

}


}


}