


















// Generated on 02/22/2023 19:13:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildUpdateApplicationMessage : NetworkMessage
{

public const uint Id = 7375;
public override uint MessageId
{
    get { return Id; }
}

public string applyText;
        public uint guildId;
        

public GuildUpdateApplicationMessage()
{
}

public GuildUpdateApplicationMessage(string applyText, uint guildId)
        {
            this.applyText = applyText;
            this.guildId = guildId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(applyText);
            writer.WriteVarInt((int)guildId);
            

}

public override void Deserialize(IDataReader reader)
{

applyText = reader.ReadUTF();
            guildId = reader.ReadVarUhInt();
            

}


}


}