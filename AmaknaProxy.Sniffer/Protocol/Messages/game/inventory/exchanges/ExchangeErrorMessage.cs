


















// Generated on 02/22/2023 19:13:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeErrorMessage : NetworkMessage
{

public const uint Id = 8694;
public override uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public ExchangeErrorMessage()
{
}

public ExchangeErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(errorType);
            

}

public override void Deserialize(IDataReader reader)
{

errorType = reader.ReadSbyte();
            

}


}


}