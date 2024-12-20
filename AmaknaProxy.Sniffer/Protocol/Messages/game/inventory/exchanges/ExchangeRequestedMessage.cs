


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeRequestedMessage : NetworkMessage
{

public const uint Id = 1417;
public override uint MessageId
{
    get { return Id; }
}

public sbyte exchangeType;
        

public ExchangeRequestedMessage()
{
}

public ExchangeRequestedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(exchangeType);
            

}

public override void Deserialize(IDataReader reader)
{

exchangeType = reader.ReadSbyte();
            

}


}


}