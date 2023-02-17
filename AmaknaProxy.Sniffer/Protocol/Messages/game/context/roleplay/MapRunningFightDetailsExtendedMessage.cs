


















// Generated on 02/17/2023 18:45:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MapRunningFightDetailsExtendedMessage : MapRunningFightDetailsMessage
{

public const uint Id = 9358;
public override uint MessageId
{
    get { return Id; }
}

public Types.NamedPartyTeam[] namedPartyTeams;
        

public MapRunningFightDetailsExtendedMessage()
{
}

public MapRunningFightDetailsExtendedMessage(uint fightId, Types.GameFightFighterLightInformations[] attackers, Types.GameFightFighterLightInformations[] defenders, Types.NamedPartyTeam[] namedPartyTeams)
         : base(fightId, attackers, defenders)
        {
            this.namedPartyTeams = namedPartyTeams;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)namedPartyTeams.Length);
            foreach (var entry in namedPartyTeams)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            namedPartyTeams = new Types.NamedPartyTeam[limit];
            for (int i = 0; i < limit; i++)
            {
                 namedPartyTeams[i] = new Types.NamedPartyTeam();
                 namedPartyTeams[i].Deserialize(reader);
            }
            

}


}


}