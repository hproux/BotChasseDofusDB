


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ShortcutBarRefreshMessage : NetworkMessage
{

public const uint Id = 1089;
public override uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public Types.Shortcut shortcut;
        

public ShortcutBarRefreshMessage()
{
}

public ShortcutBarRefreshMessage(sbyte barType, Types.Shortcut shortcut)
        {
            this.barType = barType;
            this.shortcut = shortcut;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(barType);
            writer.WriteShort(shortcut.TypeId);
            shortcut.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

barType = reader.ReadSbyte();
            shortcut = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadUShort());
            shortcut.Deserialize(reader);
            

}


}


}