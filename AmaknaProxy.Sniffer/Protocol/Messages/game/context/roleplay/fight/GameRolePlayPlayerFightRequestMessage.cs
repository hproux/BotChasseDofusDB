


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayPlayerFightRequestMessage : NetworkMessage
{

public const uint Id = 8139;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short targetCellId;
        public bool friendly;
        

public GameRolePlayPlayerFightRequestMessage()
{
}

public GameRolePlayPlayerFightRequestMessage(double targetId, short targetCellId, bool friendly)
        {
            this.targetId = targetId;
            this.targetCellId = targetCellId;
            this.friendly = friendly;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(targetId);
            writer.WriteShort(targetCellId);
            writer.WriteBoolean(friendly);
            

}

public override void Deserialize(IDataReader reader)
{

targetId = reader.ReadVarUhLong();
            targetCellId = reader.ReadShort();
            friendly = reader.ReadBoolean();
            

}


}


}