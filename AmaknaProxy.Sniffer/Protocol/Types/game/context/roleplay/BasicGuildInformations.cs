


















// Generated on 02/22/2023 19:13:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class BasicGuildInformations : AbstractSocialGroupInfos
{

public const short Id = 3099;
public override short TypeId
{
    get { return Id; }
}

public uint guildId;
        public string guildName;
        public byte guildLevel;
        

public BasicGuildInformations()
{
}

public BasicGuildInformations(uint guildId, string guildName, byte guildLevel)
        {
            this.guildId = guildId;
            this.guildName = guildName;
            this.guildLevel = guildLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)guildId);
            writer.WriteUTF(guildName);
            writer.WriteByte(guildLevel);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildId = reader.ReadVarUhInt();
            guildName = reader.ReadUTF();
            guildLevel = reader.ReadByte();
            

}


}


}