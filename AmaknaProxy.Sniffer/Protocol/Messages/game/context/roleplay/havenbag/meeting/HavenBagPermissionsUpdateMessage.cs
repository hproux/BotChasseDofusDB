


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class HavenBagPermissionsUpdateMessage : NetworkMessage
{

public const uint Id = 4297;
public override uint MessageId
{
    get { return Id; }
}

public int permissions;
        

public HavenBagPermissionsUpdateMessage()
{
}

public HavenBagPermissionsUpdateMessage(int permissions)
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