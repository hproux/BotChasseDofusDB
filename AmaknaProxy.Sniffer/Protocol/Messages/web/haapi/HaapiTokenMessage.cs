


















// Generated on 02/22/2023 19:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class HaapiTokenMessage : NetworkMessage
{

public const uint Id = 6142;
public override uint MessageId
{
    get { return Id; }
}

public string token;
        

public HaapiTokenMessage()
{
}

public HaapiTokenMessage(string token)
        {
            this.token = token;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(token);
            

}

public override void Deserialize(IDataReader reader)
{

token = reader.ReadUTF();
            

}


}


}