


















// Generated on 02/22/2023 19:13:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyNameSetErrorMessage : AbstractPartyMessage
{

public const uint Id = 6589;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public PartyNameSetErrorMessage()
{
}

public PartyNameSetErrorMessage(uint partyId, sbyte result)
         : base(partyId)
        {
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(result);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            result = reader.ReadSbyte();
            

}


}


}