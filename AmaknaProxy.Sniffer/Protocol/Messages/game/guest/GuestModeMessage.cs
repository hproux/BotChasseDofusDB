


















// Generated on 02/17/2023 18:45:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuestModeMessage : NetworkMessage
{

public const uint Id = 3302;
public override uint MessageId
{
    get { return Id; }
}

public bool active;
        

public GuestModeMessage()
{
}

public GuestModeMessage(bool active)
        {
            this.active = active;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(active);
            

}

public override void Deserialize(IDataReader reader)
{

active = reader.ReadBoolean();
            

}


}


}