


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AccessoryPreviewMessage : NetworkMessage
{

public const uint Id = 5940;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public AccessoryPreviewMessage()
{
}

public AccessoryPreviewMessage(Types.EntityLook look)
        {
            this.look = look;
        }
        

public override void Serialize(IDataWriter writer)
{

look.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}