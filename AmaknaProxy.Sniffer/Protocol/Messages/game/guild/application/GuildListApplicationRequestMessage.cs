


















// Generated on 02/17/2023 18:45:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildListApplicationRequestMessage : PaginationRequestAbstractMessage
{

public const uint Id = 4413;
public override uint MessageId
{
    get { return Id; }
}



public GuildListApplicationRequestMessage()
{
}

public GuildListApplicationRequestMessage(double offset, uint count)
         : base(offset, count)
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