


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GuildPlayerFlowActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 3798;
public override short TypeId
{
    get { return Id; }
}

public double playerId;
        public string playerName;
        public sbyte playerFlowEventType;
        

public GuildPlayerFlowActivity()
{
}

public GuildPlayerFlowActivity(uint id, double date, double playerId, string playerName, sbyte playerFlowEventType)
         : base(id, date)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.playerFlowEventType = playerFlowEventType;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(playerFlowEventType);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            playerFlowEventType = reader.ReadSbyte();
            

}


}


}