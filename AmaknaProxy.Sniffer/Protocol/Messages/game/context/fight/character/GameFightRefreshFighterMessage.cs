


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightRefreshFighterMessage : NetworkMessage
{

public const uint Id = 462;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameContextActorInformations informations;
        

public GameFightRefreshFighterMessage()
{
}

public GameFightRefreshFighterMessage(Types.GameContextActorInformations informations)
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

informations = ProtocolTypeManager.GetInstance<Types.GameContextActorInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
            

}


}


}