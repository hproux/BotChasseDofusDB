


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class CharacterMinimalGuildPublicInformations : CharacterMinimalInformations
{

public const short Id = 9695;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildRankPublicInformation rank;
        

public CharacterMinimalGuildPublicInformations()
{
}

public CharacterMinimalGuildPublicInformations(double id, string name, uint level, Types.GuildRankPublicInformation rank)
         : base(id, name, level)
        {
            this.rank = rank;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            rank.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            rank = new Types.GuildRankPublicInformation();
            rank.Deserialize(reader);
            

}


}


}