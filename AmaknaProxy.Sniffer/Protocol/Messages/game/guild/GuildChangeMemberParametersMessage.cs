


















// Generated on 02/17/2023 18:45:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildChangeMemberParametersMessage : NetworkMessage
{

public const uint Id = 8129;
public override uint MessageId
{
    get { return Id; }
}

public double memberId;
        public uint rankId;
        public sbyte experienceGivenPercent;
        

public GuildChangeMemberParametersMessage()
{
}

public GuildChangeMemberParametersMessage(double memberId, uint rankId, sbyte experienceGivenPercent)
        {
            this.memberId = memberId;
            this.rankId = rankId;
            this.experienceGivenPercent = experienceGivenPercent;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(memberId);
            writer.WriteVarInt((int)rankId);
            writer.WriteSbyte(experienceGivenPercent);
            

}

public override void Deserialize(IDataReader reader)
{

memberId = reader.ReadVarUhLong();
            rankId = reader.ReadVarUhInt();
            experienceGivenPercent = reader.ReadSbyte();
            

}


}


}