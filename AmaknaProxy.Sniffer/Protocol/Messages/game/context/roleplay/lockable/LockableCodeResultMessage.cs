


















// Generated on 02/17/2023 18:45:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class LockableCodeResultMessage : NetworkMessage
{

public const uint Id = 5274;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public LockableCodeResultMessage()
{
}

public LockableCodeResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            

}

public override void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            

}


}


}