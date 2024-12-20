


















// Generated on 02/22/2023 19:13:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AcquaintanceAddedMessage : NetworkMessage
{

public const uint Id = 8361;
public override uint MessageId
{
    get { return Id; }
}

public Types.AcquaintanceInformation acquaintanceAdded;
        

public AcquaintanceAddedMessage()
{
}

public AcquaintanceAddedMessage(Types.AcquaintanceInformation acquaintanceAdded)
        {
            this.acquaintanceAdded = acquaintanceAdded;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(acquaintanceAdded.TypeId);
            acquaintanceAdded.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

acquaintanceAdded = ProtocolTypeManager.GetInstance<Types.AcquaintanceInformation>(reader.ReadUShort());
            acquaintanceAdded.Deserialize(reader);
            

}


}


}