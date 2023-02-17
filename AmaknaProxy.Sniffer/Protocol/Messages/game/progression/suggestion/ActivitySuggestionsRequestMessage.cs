


















// Generated on 02/17/2023 18:45:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ActivitySuggestionsRequestMessage : NetworkMessage
{

public const uint Id = 4176;
public override uint MessageId
{
    get { return Id; }
}

public uint minLevel;
        public uint maxLevel;
        public uint areaId;
        public uint activityCategoryId;
        public ushort nbCards;
        

public ActivitySuggestionsRequestMessage()
{
}

public ActivitySuggestionsRequestMessage(uint minLevel, uint maxLevel, uint areaId, uint activityCategoryId, ushort nbCards)
        {
            this.minLevel = minLevel;
            this.maxLevel = maxLevel;
            this.areaId = areaId;
            this.activityCategoryId = activityCategoryId;
            this.nbCards = nbCards;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)minLevel);
            writer.WriteVarShort((int)maxLevel);
            writer.WriteVarShort((int)areaId);
            writer.WriteVarShort((int)activityCategoryId);
            writer.WriteUShort(nbCards);
            

}

public override void Deserialize(IDataReader reader)
{

minLevel = reader.ReadVarUhShort();
            maxLevel = reader.ReadVarUhShort();
            areaId = reader.ReadVarUhShort();
            activityCategoryId = reader.ReadVarUhShort();
            nbCards = reader.ReadUShort();
            

}


}


}