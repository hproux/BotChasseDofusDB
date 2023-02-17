


















// Generated on 02/17/2023 18:45:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayShowActorMessage : NetworkMessage
{

public const uint Id = 7514;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameRolePlayActorInformations informations;
        

public GameRolePlayShowActorMessage()
{
}

public GameRolePlayShowActorMessage(Types.GameRolePlayActorInformations informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

informations = ProtocolTypeManager.GetInstance<Types.GameRolePlayActorInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
            

}


}


}