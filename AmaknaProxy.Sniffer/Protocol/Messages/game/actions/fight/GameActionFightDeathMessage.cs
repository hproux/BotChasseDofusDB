


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameActionFightDeathMessage : AbstractGameActionMessage
{

public const uint Id = 4961;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        

public GameActionFightDeathMessage()
{
}

public GameActionFightDeathMessage(uint actionId, double sourceId, double targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            

}


}


}