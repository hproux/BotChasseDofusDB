


















// Generated on 02/22/2023 19:13:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AllianceGuildLeavingMessage : NetworkMessage
{

public const uint Id = 1732;
public override uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public uint guildId;
        

public AllianceGuildLeavingMessage()
{
}

public AllianceGuildLeavingMessage(bool kicked, uint guildId)
        {
            this.kicked = kicked;
            this.guildId = guildId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteVarInt((int)guildId);
            

}

public override void Deserialize(IDataReader reader)
{

kicked = reader.ReadBoolean();
            guildId = reader.ReadVarUhInt();
            

}


}


}