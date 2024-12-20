


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightPlacementSwapPositionsRequestMessage : GameFightPlacementPositionRequestMessage
{

public const uint Id = 7094;
public override uint MessageId
{
    get { return Id; }
}

public double requestedId;
        

public GameFightPlacementSwapPositionsRequestMessage()
{
}

public GameFightPlacementSwapPositionsRequestMessage(uint cellId, double requestedId)
         : base(cellId)
        {
            this.requestedId = requestedId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(requestedId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            requestedId = reader.ReadDouble();
            

}


}


}