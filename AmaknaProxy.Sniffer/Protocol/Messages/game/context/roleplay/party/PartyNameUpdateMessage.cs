


















// Generated on 02/17/2023 18:45:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyNameUpdateMessage : AbstractPartyMessage
{

public const uint Id = 7133;
public override uint MessageId
{
    get { return Id; }
}

public string partyName;
        

public PartyNameUpdateMessage()
{
}

public PartyNameUpdateMessage(uint partyId, string partyName)
         : base(partyId)
        {
            this.partyName = partyName;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(partyName);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            partyName = reader.ReadUTF();
            

}


}


}