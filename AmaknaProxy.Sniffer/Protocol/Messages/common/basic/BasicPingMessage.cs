


















// Generated on 02/22/2023 19:13:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class BasicPingMessage : NetworkMessage
{

public const uint Id = 311;
public override uint MessageId
{
    get { return Id; }
}

public bool quiet;
        

public BasicPingMessage()
{
}

public BasicPingMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(quiet);
            

}

public override void Deserialize(IDataReader reader)
{

quiet = reader.ReadBoolean();
            

}


}


}