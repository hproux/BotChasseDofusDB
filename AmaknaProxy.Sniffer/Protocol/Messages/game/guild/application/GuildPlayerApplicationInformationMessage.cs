


















// Generated on 02/22/2023 19:13:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildPlayerApplicationInformationMessage : GuildPlayerApplicationAbstractMessage
{

public const uint Id = 7125;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations guildInformation;
        public Types.GuildApplicationInformation apply;
        

public GuildPlayerApplicationInformationMessage()
{
}

public GuildPlayerApplicationInformationMessage(Types.GuildInformations guildInformation, Types.GuildApplicationInformation apply)
        {
            this.guildInformation = guildInformation;
            this.apply = apply;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildInformation.Serialize(writer);
            apply.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildInformation = new Types.GuildInformations();
            guildInformation.Deserialize(reader);
            apply = new Types.GuildApplicationInformation();
            apply.Deserialize(reader);
            

}


}


}