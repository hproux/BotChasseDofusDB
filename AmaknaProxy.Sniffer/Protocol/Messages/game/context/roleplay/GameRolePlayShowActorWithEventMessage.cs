


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
{

public const uint Id = 9569;
public override uint MessageId
{
    get { return Id; }
}

public sbyte actorEventId;
        

public GameRolePlayShowActorWithEventMessage()
{
}

public GameRolePlayShowActorWithEventMessage(Types.GameRolePlayActorInformations informations, sbyte actorEventId)
         : base(informations)
        {
            this.actorEventId = actorEventId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(actorEventId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            actorEventId = reader.ReadSbyte();
            

}


}


}