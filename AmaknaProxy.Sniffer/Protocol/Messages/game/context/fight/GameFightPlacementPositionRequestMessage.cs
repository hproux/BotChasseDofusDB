


















// Generated on 02/17/2023 18:45:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightPlacementPositionRequestMessage : NetworkMessage
{

public const uint Id = 4517;
public override uint MessageId
{
    get { return Id; }
}

public uint cellId;
        

public GameFightPlacementPositionRequestMessage()
{
}

public GameFightPlacementPositionRequestMessage(uint cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            

}

public override void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            

}


}


}