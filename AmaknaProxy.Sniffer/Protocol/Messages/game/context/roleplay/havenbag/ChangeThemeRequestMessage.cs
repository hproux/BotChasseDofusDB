


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ChangeThemeRequestMessage : NetworkMessage
{

public const uint Id = 451;
public override uint MessageId
{
    get { return Id; }
}

public sbyte theme;
        

public ChangeThemeRequestMessage()
{
}

public ChangeThemeRequestMessage(sbyte theme)
        {
            this.theme = theme;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(theme);
            

}

public override void Deserialize(IDataReader reader)
{

theme = reader.ReadSbyte();
            

}


}


}