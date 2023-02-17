


















// Generated on 02/17/2023 18:45:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PortalUseRequestMessage : NetworkMessage
{

public const uint Id = 4099;
public override uint MessageId
{
    get { return Id; }
}

public uint portalId;
        

public PortalUseRequestMessage()
{
}

public PortalUseRequestMessage(uint portalId)
        {
            this.portalId = portalId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)portalId);
            

}

public override void Deserialize(IDataReader reader)
{

portalId = reader.ReadVarUhInt();
            

}


}


}