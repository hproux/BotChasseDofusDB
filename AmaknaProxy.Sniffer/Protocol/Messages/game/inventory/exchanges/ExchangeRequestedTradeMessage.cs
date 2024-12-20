


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
{

public const uint Id = 5307;
public override uint MessageId
{
    get { return Id; }
}

public double source;
        public double target;
        

public ExchangeRequestedTradeMessage()
{
}

public ExchangeRequestedTradeMessage(sbyte exchangeType, double source, double target)
         : base(exchangeType)
        {
            this.source = source;
            this.target = target;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(source);
            writer.WriteVarLong(target);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            source = reader.ReadVarUhLong();
            target = reader.ReadVarUhLong();
            

}


}


}