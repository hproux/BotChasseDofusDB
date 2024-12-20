


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PresetSavedMessage : NetworkMessage
{

public const uint Id = 2124;
public override uint MessageId
{
    get { return Id; }
}

public short presetId;
        public Types.Preset preset;
        

public PresetSavedMessage()
{
}

public PresetSavedMessage(short presetId, Types.Preset preset)
        {
            this.presetId = presetId;
            this.preset = preset;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            writer.WriteShort(preset.TypeId);
            preset.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            preset = ProtocolTypeManager.GetInstance<Types.Preset>(reader.ReadUShort());
            preset.Deserialize(reader);
            

}


}


}