


















// Generated on 02/17/2023 18:45:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class NumericWhoIsRequestMessage : NetworkMessage
{

public const uint Id = 7392;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public NumericWhoIsRequestMessage()
{
}

public NumericWhoIsRequestMessage(double playerId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            

}


}


}