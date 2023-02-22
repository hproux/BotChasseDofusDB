


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayAggressionMessage : NetworkMessage
{

public const uint Id = 3544;
public override uint MessageId
{
    get { return Id; }
}

public double attackerId;
        public double defenderId;
        

public GameRolePlayAggressionMessage()
{
}

public GameRolePlayAggressionMessage(double attackerId, double defenderId)
        {
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(attackerId);
            writer.WriteVarLong(defenderId);
            

}

public override void Deserialize(IDataReader reader)
{

attackerId = reader.ReadVarUhLong();
            defenderId = reader.ReadVarUhLong();
            

}


}


}