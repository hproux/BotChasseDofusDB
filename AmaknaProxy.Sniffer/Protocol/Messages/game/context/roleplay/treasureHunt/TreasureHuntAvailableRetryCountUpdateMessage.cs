


















// Generated on 02/22/2023 19:13:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TreasureHuntAvailableRetryCountUpdateMessage : NetworkMessage
{

public const uint Id = 7523;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public int availableRetryCount;
        

public TreasureHuntAvailableRetryCountUpdateMessage()
{
}

public TreasureHuntAvailableRetryCountUpdateMessage(sbyte questType, int availableRetryCount)
        {
            this.questType = questType;
            this.availableRetryCount = availableRetryCount;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteInt(availableRetryCount);
            

}

public override void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            availableRetryCount = reader.ReadInt();
            

}


}


}