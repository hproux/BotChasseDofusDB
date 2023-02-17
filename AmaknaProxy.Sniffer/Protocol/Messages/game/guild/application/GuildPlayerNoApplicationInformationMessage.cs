


















// Generated on 02/17/2023 18:45:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildPlayerNoApplicationInformationMessage : GuildPlayerApplicationAbstractMessage
{

public const uint Id = 2822;
public override uint MessageId
{
    get { return Id; }
}



public GuildPlayerNoApplicationInformationMessage()
{
}



public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}