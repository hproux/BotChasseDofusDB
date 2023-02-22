


















// Generated on 02/22/2023 19:13:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeStartOkMulticraftCustomerMessage : NetworkMessage
{

public const uint Id = 3687;
public override uint MessageId
{
    get { return Id; }
}

public uint skillId;
        public byte crafterJobLevel;
        

public ExchangeStartOkMulticraftCustomerMessage()
{
}

public ExchangeStartOkMulticraftCustomerMessage(uint skillId, byte crafterJobLevel)
        {
            this.skillId = skillId;
            this.crafterJobLevel = crafterJobLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            writer.WriteByte(crafterJobLevel);
            

}

public override void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            crafterJobLevel = reader.ReadByte();
            

}


}


}