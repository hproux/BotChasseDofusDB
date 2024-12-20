


















// Generated on 02/22/2023 19:13:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class FinishMoveSetRequestMessage : NetworkMessage
{

public const uint Id = 4451;
public override uint MessageId
{
    get { return Id; }
}

public int finishMoveId;
        public bool finishMoveState;
        

public FinishMoveSetRequestMessage()
{
}

public FinishMoveSetRequestMessage(int finishMoveId, bool finishMoveState)
        {
            this.finishMoveId = finishMoveId;
            this.finishMoveState = finishMoveState;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(finishMoveId);
            writer.WriteBoolean(finishMoveState);
            

}

public override void Deserialize(IDataReader reader)
{

finishMoveId = reader.ReadInt();
            finishMoveState = reader.ReadBoolean();
            

}


}


}