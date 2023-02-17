


















// Generated on 02/17/2023 18:45:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AllianceFactsRequestMessage : NetworkMessage
{

public const uint Id = 3781;
public override uint MessageId
{
    get { return Id; }
}

public uint allianceId;
        

public AllianceFactsRequestMessage()
{
}

public AllianceFactsRequestMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)allianceId);
            

}

public override void Deserialize(IDataReader reader)
{

allianceId = reader.ReadVarUhInt();
            

}


}


}