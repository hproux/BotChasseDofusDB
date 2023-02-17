


















// Generated on 02/17/2023 18:45:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class InteractiveElementUpdatedMessage : NetworkMessage
{

public const uint Id = 6902;
public override uint MessageId
{
    get { return Id; }
}

public Types.InteractiveElement interactiveElement;
        

public InteractiveElementUpdatedMessage()
{
}

public InteractiveElementUpdatedMessage(Types.InteractiveElement interactiveElement)
        {
            this.interactiveElement = interactiveElement;
        }
        

public override void Serialize(IDataWriter writer)
{

interactiveElement.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

interactiveElement = new Types.InteractiveElement();
            interactiveElement.Deserialize(reader);
            

}


}


}