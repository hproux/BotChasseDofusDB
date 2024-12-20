


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class StartupActionAddMessage : NetworkMessage
{

public const uint Id = 4490;
public override uint MessageId
{
    get { return Id; }
}

public Types.StartupActionAddObject newAction;
        

public StartupActionAddMessage()
{
}

public StartupActionAddMessage(Types.StartupActionAddObject newAction)
        {
            this.newAction = newAction;
        }
        

public override void Serialize(IDataWriter writer)
{

newAction.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

newAction = new Types.StartupActionAddObject();
            newAction.Deserialize(reader);
            

}


}


}