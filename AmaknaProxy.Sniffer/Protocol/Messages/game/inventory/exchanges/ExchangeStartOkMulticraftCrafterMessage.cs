


















// Generated on 02/22/2023 19:13:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
{

public const uint Id = 341;
public override uint MessageId
{
    get { return Id; }
}

public uint skillId;
        

public ExchangeStartOkMulticraftCrafterMessage()
{
}

public ExchangeStartOkMulticraftCrafterMessage(uint skillId)
        {
            this.skillId = skillId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            

}

public override void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            

}


}


}