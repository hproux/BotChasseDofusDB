


















// Generated on 02/22/2023 19:13:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildMotdSetErrorMessage : SocialNoticeSetErrorMessage
{

public const uint Id = 4410;
public override uint MessageId
{
    get { return Id; }
}



public GuildMotdSetErrorMessage()
{
}

public GuildMotdSetErrorMessage(sbyte reason)
         : base(reason)
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