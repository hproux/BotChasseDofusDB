


















// Generated on 02/22/2023 19:13:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeCraftCountRequestMessage : NetworkMessage
{

public const uint Id = 9737;
public override uint MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeCraftCountRequestMessage()
{
}

public ExchangeCraftCountRequestMessage(int count)
        {
            this.count = count;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)count);
            

}

public override void Deserialize(IDataReader reader)
{

count = reader.ReadVarInt();
            

}


}


}