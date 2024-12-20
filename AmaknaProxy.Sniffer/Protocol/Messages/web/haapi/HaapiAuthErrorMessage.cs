


















// Generated on 02/22/2023 19:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class HaapiAuthErrorMessage : NetworkMessage
{

public const uint Id = 475;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        

public HaapiAuthErrorMessage()
{
}

public HaapiAuthErrorMessage(sbyte type)
        {
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            

}


}


}