


















// Generated on 02/22/2023 19:13:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class LockableStateUpdateAbstractMessage : NetworkMessage
{

public const uint Id = 4249;
public override uint MessageId
{
    get { return Id; }
}

public bool locked;
        

public LockableStateUpdateAbstractMessage()
{
}

public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(locked);
            

}

public override void Deserialize(IDataReader reader)
{

locked = reader.ReadBoolean();
            

}


}


}