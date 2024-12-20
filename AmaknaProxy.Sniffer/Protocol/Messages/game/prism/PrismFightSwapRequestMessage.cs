


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PrismFightSwapRequestMessage : NetworkMessage
{

public const uint Id = 5555;
public override uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public double targetId;
        

public PrismFightSwapRequestMessage()
{
}

public PrismFightSwapRequestMessage(uint subAreaId, double targetId)
        {
            this.subAreaId = subAreaId;
            this.targetId = targetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarLong(targetId);
            

}

public override void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            targetId = reader.ReadVarUhLong();
            

}


}


}