


















// Generated on 02/17/2023 18:45:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class IgnoredAddFailureMessage : NetworkMessage
{

public const uint Id = 1684;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public IgnoredAddFailureMessage()
{
}

public IgnoredAddFailureMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(reason);
            

}

public override void Deserialize(IDataReader reader)
{

reason = reader.ReadSbyte();
            

}


}


}