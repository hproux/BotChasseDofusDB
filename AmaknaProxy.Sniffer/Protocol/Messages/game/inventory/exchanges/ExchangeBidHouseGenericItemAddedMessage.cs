


















// Generated on 02/22/2023 19:13:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeBidHouseGenericItemAddedMessage : NetworkMessage
{

public const uint Id = 2496;
public override uint MessageId
{
    get { return Id; }
}

public uint objGenericId;
        

public ExchangeBidHouseGenericItemAddedMessage()
{
}

public ExchangeBidHouseGenericItemAddedMessage(uint objGenericId)
        {
            this.objGenericId = objGenericId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objGenericId);
            

}

public override void Deserialize(IDataReader reader)
{

objGenericId = reader.ReadVarUhInt();
            

}


}


}