


















// Generated on 02/22/2023 19:13:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GuildInAllianceVersatileInformations : GuildVersatileInformations
{

public const short Id = 5353;
public override short TypeId
{
    get { return Id; }
}

public uint allianceId;
        

public GuildInAllianceVersatileInformations()
{
}

public GuildInAllianceVersatileInformations(uint guildId, double leaderId, byte guildLevel, byte nbMembers, uint allianceId)
         : base(guildId, leaderId, guildLevel, nbMembers)
        {
            this.allianceId = allianceId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)allianceId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceId = reader.ReadVarUhInt();
            

}


}


}