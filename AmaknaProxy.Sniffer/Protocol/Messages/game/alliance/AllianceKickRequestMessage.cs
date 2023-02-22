


















// Generated on 02/22/2023 19:13:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AllianceKickRequestMessage : NetworkMessage
{

public const uint Id = 4496;
public override uint MessageId
{
    get { return Id; }
}

public uint kickedId;
        

public AllianceKickRequestMessage()
{
}

public AllianceKickRequestMessage(uint kickedId)
        {
            this.kickedId = kickedId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)kickedId);
            

}

public override void Deserialize(IDataReader reader)
{

kickedId = reader.ReadVarUhInt();
            

}


}


}