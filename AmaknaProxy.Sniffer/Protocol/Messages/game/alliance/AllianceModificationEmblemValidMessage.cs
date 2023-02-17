


















// Generated on 02/17/2023 18:45:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AllianceModificationEmblemValidMessage : NetworkMessage
{

public const uint Id = 6102;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildEmblem Alliancemblem;
        

public AllianceModificationEmblemValidMessage()
{
}

public AllianceModificationEmblemValidMessage(Types.GuildEmblem Alliancemblem)
        {
            this.Alliancemblem = Alliancemblem;
        }
        

public override void Serialize(IDataWriter writer)
{

Alliancemblem.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
            

}


}


}