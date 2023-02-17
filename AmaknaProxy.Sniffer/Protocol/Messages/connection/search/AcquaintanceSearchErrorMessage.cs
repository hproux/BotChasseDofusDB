


















// Generated on 02/17/2023 18:45:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AcquaintanceSearchErrorMessage : NetworkMessage
{

public const uint Id = 4005;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public AcquaintanceSearchErrorMessage()
{
}

public AcquaintanceSearchErrorMessage(sbyte reason)
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