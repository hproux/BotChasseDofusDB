


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GuildRankActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 3613;
public override short TypeId
{
    get { return Id; }
}

public sbyte rankActivityType;
        public Types.GuildRankMinimalInformation guildRankMinimalInfos;
        

public GuildRankActivity()
{
}

public GuildRankActivity(uint id, double date, sbyte rankActivityType, Types.GuildRankMinimalInformation guildRankMinimalInfos)
         : base(id, date)
        {
            this.rankActivityType = rankActivityType;
            this.guildRankMinimalInfos = guildRankMinimalInfos;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(rankActivityType);
            guildRankMinimalInfos.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            rankActivityType = reader.ReadSbyte();
            guildRankMinimalInfos = new Types.GuildRankMinimalInformation();
            guildRankMinimalInfos.Deserialize(reader);
            

}


}


}