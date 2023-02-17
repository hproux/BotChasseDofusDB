


















// Generated on 02/17/2023 18:45:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class BreachTeleportResponseMessage : NetworkMessage
{

public const uint Id = 8020;
public override uint MessageId
{
    get { return Id; }
}

public bool teleported;
        

public BreachTeleportResponseMessage()
{
}

public BreachTeleportResponseMessage(bool teleported)
        {
            this.teleported = teleported;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(teleported);
            

}

public override void Deserialize(IDataReader reader)
{

teleported = reader.ReadBoolean();
            

}


}


}