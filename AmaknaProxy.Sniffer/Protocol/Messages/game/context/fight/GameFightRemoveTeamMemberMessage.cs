


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightRemoveTeamMemberMessage : NetworkMessage
{

public const uint Id = 5999;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public sbyte teamId;
        public double charId;
        

public GameFightRemoveTeamMemberMessage()
{
}

public GameFightRemoveTeamMemberMessage(uint fightId, sbyte teamId, double charId)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.charId = charId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteSbyte(teamId);
            writer.WriteDouble(charId);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            teamId = reader.ReadSbyte();
            charId = reader.ReadDouble();
            

}


}


}