


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PresetSaveErrorMessage : NetworkMessage
{

public const uint Id = 8665;
public override uint MessageId
{
    get { return Id; }
}

public short presetId;
        public sbyte code;
        

public PresetSaveErrorMessage()
{
}

public PresetSaveErrorMessage(short presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            writer.WriteSbyte(code);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            code = reader.ReadSbyte();
            

}


}


}