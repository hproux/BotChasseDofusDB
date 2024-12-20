


















// Generated on 02/22/2023 19:13:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TreasureHuntFlagRemoveRequestMessage : NetworkMessage
{

public const uint Id = 1209;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte index;
        

public TreasureHuntFlagRemoveRequestMessage()
{
}

public TreasureHuntFlagRemoveRequestMessage(sbyte questType, sbyte index)
        {
            this.questType = questType;
            this.index = index;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteSbyte(index);
            

}

public override void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            index = reader.ReadSbyte();
            

}


}


}