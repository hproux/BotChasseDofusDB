


















// Generated on 02/22/2023 19:13:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ChallengeFightJoinRefusedMessage : NetworkMessage
{

public const uint Id = 4363;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        public sbyte reason;
        

public ChallengeFightJoinRefusedMessage()
{
}

public ChallengeFightJoinRefusedMessage(double playerId, sbyte reason)
        {
            this.playerId = playerId;
            this.reason = reason;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteSbyte(reason);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            reason = reader.ReadSbyte();
            

}


}


}