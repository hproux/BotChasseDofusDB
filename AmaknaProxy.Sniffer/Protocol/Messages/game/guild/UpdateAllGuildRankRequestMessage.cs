


















// Generated on 02/22/2023 19:13:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class UpdateAllGuildRankRequestMessage : NetworkMessage
{

public const uint Id = 4628;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildRankInformation[] ranks;
        

public UpdateAllGuildRankRequestMessage()
{
}

public UpdateAllGuildRankRequestMessage(Types.GuildRankInformation[] ranks)
        {
            this.ranks = ranks;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ranks.Length);
            foreach (var entry in ranks)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ranks = new Types.GuildRankInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 ranks[i] = new Types.GuildRankInformation();
                 ranks[i].Deserialize(reader);
            }
            

}


}


}