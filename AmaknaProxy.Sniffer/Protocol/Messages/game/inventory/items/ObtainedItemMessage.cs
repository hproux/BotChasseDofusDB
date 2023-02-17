


















// Generated on 02/17/2023 18:45:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ObtainedItemMessage : NetworkMessage
{

public const uint Id = 9033;
public override uint MessageId
{
    get { return Id; }
}

public uint genericId;
        public uint baseQuantity;
        

public ObtainedItemMessage()
{
}

public ObtainedItemMessage(uint genericId, uint baseQuantity)
        {
            this.genericId = genericId;
            this.baseQuantity = baseQuantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)genericId);
            writer.WriteVarInt((int)baseQuantity);
            

}

public override void Deserialize(IDataReader reader)
{

genericId = reader.ReadVarUhInt();
            baseQuantity = reader.ReadVarUhInt();
            

}


}


}