


















// Generated on 02/17/2023 18:45:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildMemberLeavingMessage : NetworkMessage
{

public const uint Id = 5346;
public override uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public double memberId;
        

public GuildMemberLeavingMessage()
{
}

public GuildMemberLeavingMessage(bool kicked, double memberId)
        {
            this.kicked = kicked;
            this.memberId = memberId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteVarLong(memberId);
            

}

public override void Deserialize(IDataReader reader)
{

kicked = reader.ReadBoolean();
            memberId = reader.ReadVarUhLong();
            

}


}


}