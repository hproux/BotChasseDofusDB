


















// Generated on 02/22/2023 19:13:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class LifePointsRegenEndMessage : UpdateLifePointsMessage
{

public const uint Id = 6929;
public override uint MessageId
{
    get { return Id; }
}

public uint lifePointsGained;
        

public LifePointsRegenEndMessage()
{
}

public LifePointsRegenEndMessage(uint lifePoints, uint maxLifePoints, uint lifePointsGained)
         : base(lifePoints, maxLifePoints)
        {
            this.lifePointsGained = lifePointsGained;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)lifePointsGained);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            lifePointsGained = reader.ReadVarUhInt();
            

}


}


}