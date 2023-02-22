


















// Generated on 02/22/2023 19:13:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GuildInsiderFactSheetInformations : GuildFactSheetInformations
{

public const short Id = 487;
public override short TypeId
{
    get { return Id; }
}

public string leaderName;
        public uint nbConnectedMembers;
        public sbyte nbTaxCollectors;
        

public GuildInsiderFactSheetInformations()
{
}

public GuildInsiderFactSheetInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, double leaderId, uint nbMembers, short lastActivityDay, Types.GuildRecruitmentInformation recruitment, int nbPendingApply, string leaderName, uint nbConnectedMembers, sbyte nbTaxCollectors)
         : base(guildId, guildName, guildLevel, guildEmblem, leaderId, nbMembers, lastActivityDay, recruitment, nbPendingApply)
        {
            this.leaderName = leaderName;
            this.nbConnectedMembers = nbConnectedMembers;
            this.nbTaxCollectors = nbTaxCollectors;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(leaderName);
            writer.WriteVarShort((int)nbConnectedMembers);
            writer.WriteSbyte(nbTaxCollectors);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            leaderName = reader.ReadUTF();
            nbConnectedMembers = reader.ReadVarUhShort();
            nbTaxCollectors = reader.ReadSbyte();
            

}


}


}