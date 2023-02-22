


















// Generated on 02/22/2023 19:13:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ReloginTokenStatusMessage : NetworkMessage
{

public const uint Id = 4736;
public override uint MessageId
{
    get { return Id; }
}

public bool validToken;
        public string token;
        

public ReloginTokenStatusMessage()
{
}

public ReloginTokenStatusMessage(bool validToken, string token)
        {
            this.validToken = validToken;
            this.token = token;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUTF(token);
            

}

public override void Deserialize(IDataReader reader)
{

validToken = reader.ReadBoolean();
            token = reader.ReadUTF();
            

}


}


}