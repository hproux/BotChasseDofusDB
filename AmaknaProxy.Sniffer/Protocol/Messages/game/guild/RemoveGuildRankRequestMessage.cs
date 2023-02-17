


















// Generated on 02/17/2023 18:45:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class RemoveGuildRankRequestMessage : NetworkMessage
{

public const uint Id = 7055;
public override uint MessageId
{
    get { return Id; }
}

public uint rankId;
        public uint newRankId;
        

public RemoveGuildRankRequestMessage()
{
}

public RemoveGuildRankRequestMessage(uint rankId, uint newRankId)
        {
            this.rankId = rankId;
            this.newRankId = newRankId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)rankId);
            writer.WriteVarInt((int)newRankId);
            

}

public override void Deserialize(IDataReader reader)
{

rankId = reader.ReadVarUhInt();
            newRankId = reader.ReadVarUhInt();
            

}


}


}