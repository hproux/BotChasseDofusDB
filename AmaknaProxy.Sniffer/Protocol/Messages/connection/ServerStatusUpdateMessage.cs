


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ServerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 3;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations server;
        

public ServerStatusUpdateMessage()
{
}

public ServerStatusUpdateMessage(Types.GameServerInformations server)
        {
            this.server = server;
        }
        

public override void Serialize(IDataWriter writer)
{

server.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

server = new Types.GameServerInformations();
            server.Deserialize(reader);
            

}


}


}