


















// Generated on 02/22/2023 19:13:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameActionFightTeleportOnSameMapMessage : AbstractGameActionMessage
{

public const uint Id = 5405;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short cellId;
        

public GameActionFightTeleportOnSameMapMessage()
{
}

public GameActionFightTeleportOnSameMapMessage(uint actionId, double sourceId, double targetId, short cellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            cellId = reader.ReadShort();
            

}


}


}