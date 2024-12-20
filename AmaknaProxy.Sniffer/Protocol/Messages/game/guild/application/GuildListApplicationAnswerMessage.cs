


















// Generated on 02/22/2023 19:13:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildListApplicationAnswerMessage : PaginationAnswerAbstractMessage
{

public const uint Id = 9667;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildApplicationInformation[] applies;
        

public GuildListApplicationAnswerMessage()
{
}

public GuildListApplicationAnswerMessage(double offset, uint count, uint total, Types.GuildApplicationInformation[] applies)
         : base(offset, count, total)
        {
            this.applies = applies;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)applies.Length);
            foreach (var entry in applies)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            applies = new Types.GuildApplicationInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 applies[i] = new Types.GuildApplicationInformation();
                 applies[i].Deserialize(reader);
            }
            

}


}


}