


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class SetEnableAVARequestMessage : NetworkMessage
{

public const uint Id = 8285;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public SetEnableAVARequestMessage()
{
}

public SetEnableAVARequestMessage(bool enable)
        {
            this.enable = enable;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public override void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}