


















// Generated on 02/17/2023 18:45:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayArenaSwitchToGameServerMessage : NetworkMessage
{

public const uint Id = 7604;
public override uint MessageId
{
    get { return Id; }
}

public bool validToken;
        public string token;
        public short homeServerId;
        

public GameRolePlayArenaSwitchToGameServerMessage()
{
}

public GameRolePlayArenaSwitchToGameServerMessage(bool validToken, string token, short homeServerId)
        {
            this.validToken = validToken;
            this.token = token;
            this.homeServerId = homeServerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUTF(token);
            writer.WriteShort(homeServerId);
            

}

public override void Deserialize(IDataReader reader)
{

validToken = reader.ReadBoolean();
            token = reader.ReadUTF();
            homeServerId = reader.ReadShort();
            

}


}


}