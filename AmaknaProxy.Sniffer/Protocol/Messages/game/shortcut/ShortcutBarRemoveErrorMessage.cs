


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ShortcutBarRemoveErrorMessage : NetworkMessage
{

public const uint Id = 5877;
public override uint MessageId
{
    get { return Id; }
}

public sbyte error;
        

public ShortcutBarRemoveErrorMessage()
{
}

public ShortcutBarRemoveErrorMessage(sbyte error)
        {
            this.error = error;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(error);
            

}

public override void Deserialize(IDataReader reader)
{

error = reader.ReadSbyte();
            

}


}


}