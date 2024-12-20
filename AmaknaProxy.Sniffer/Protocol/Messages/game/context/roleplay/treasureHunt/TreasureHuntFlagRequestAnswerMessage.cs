


















// Generated on 02/22/2023 19:13:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TreasureHuntFlagRequestAnswerMessage : NetworkMessage
{

public const uint Id = 4502;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte result;
        public sbyte index;
        

public TreasureHuntFlagRequestAnswerMessage()
{
}

public TreasureHuntFlagRequestAnswerMessage(sbyte questType, sbyte result, sbyte index)
        {
            this.questType = questType;
            this.result = result;
            this.index = index;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteSbyte(result);
            writer.WriteSbyte(index);
            

}

public override void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            result = reader.ReadSbyte();
            index = reader.ReadSbyte();
            

}


}


}