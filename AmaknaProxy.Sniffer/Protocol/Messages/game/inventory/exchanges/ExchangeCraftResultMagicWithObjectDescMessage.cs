


















// Generated on 02/22/2023 19:13:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeCraftResultMagicWithObjectDescMessage : ExchangeCraftResultWithObjectDescMessage
{

public const uint Id = 8417;
public override uint MessageId
{
    get { return Id; }
}

public sbyte magicPoolStatus;
        

public ExchangeCraftResultMagicWithObjectDescMessage()
{
}

public ExchangeCraftResultMagicWithObjectDescMessage(sbyte craftResult, Types.ObjectItemNotInContainer objectInfo, sbyte magicPoolStatus)
         : base(craftResult, objectInfo)
        {
            this.magicPoolStatus = magicPoolStatus;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(magicPoolStatus);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            magicPoolStatus = reader.ReadSbyte();
            

}


}


}