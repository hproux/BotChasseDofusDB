


















// Generated on 02/22/2023 19:13:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class BreachSavedMessage : NetworkMessage
{

public const uint Id = 6598;
public override uint MessageId
{
    get { return Id; }
}

public bool saved;
        

public BreachSavedMessage()
{
}

public BreachSavedMessage(bool saved)
        {
            this.saved = saved;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(saved);
            

}

public override void Deserialize(IDataReader reader)
{

saved = reader.ReadBoolean();
            

}


}


}