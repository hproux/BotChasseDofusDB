


















// Generated on 02/17/2023 18:45:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class HavenBagPermissionsUpdateRequestMessage : NetworkMessage
{

public const uint Id = 3448;
public override uint MessageId
{
    get { return Id; }
}

public int permissions;
        

public HavenBagPermissionsUpdateRequestMessage()
{
}

public HavenBagPermissionsUpdateRequestMessage(int permissions)
        {
            this.permissions = permissions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(permissions);
            

}

public override void Deserialize(IDataReader reader)
{

permissions = reader.ReadInt();
            

}


}


}