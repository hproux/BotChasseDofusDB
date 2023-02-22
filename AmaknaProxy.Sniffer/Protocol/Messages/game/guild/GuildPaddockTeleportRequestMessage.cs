


















// Generated on 02/22/2023 19:13:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildPaddockTeleportRequestMessage : NetworkMessage
{

public const uint Id = 991;
public override uint MessageId
{
    get { return Id; }
}

public double paddockId;
        

public GuildPaddockTeleportRequestMessage()
{
}

public GuildPaddockTeleportRequestMessage(double paddockId)
        {
            this.paddockId = paddockId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(paddockId);
            

}

public override void Deserialize(IDataReader reader)
{

paddockId = reader.ReadDouble();
            

}


}


}