


















// Generated on 02/22/2023 19:13:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
{

public const uint Id = 6088;
public override uint MessageId
{
    get { return Id; }
}

public sbyte wrongFlagCount;
        

public TreasureHuntDigRequestAnswerFailedMessage()
{
}

public TreasureHuntDigRequestAnswerFailedMessage(sbyte questType, sbyte result, sbyte wrongFlagCount)
         : base(questType, result)
        {
            this.wrongFlagCount = wrongFlagCount;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(wrongFlagCount);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            wrongFlagCount = reader.ReadSbyte();
            

}


}


}