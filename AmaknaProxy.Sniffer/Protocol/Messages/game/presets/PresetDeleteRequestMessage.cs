


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PresetDeleteRequestMessage : NetworkMessage
{

public const uint Id = 2584;
public override uint MessageId
{
    get { return Id; }
}

public short presetId;
        

public PresetDeleteRequestMessage()
{
}

public PresetDeleteRequestMessage(short presetId)
        {
            this.presetId = presetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            

}


}


}