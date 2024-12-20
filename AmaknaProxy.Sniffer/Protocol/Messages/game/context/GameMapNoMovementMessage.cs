


















// Generated on 02/22/2023 19:13:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameMapNoMovementMessage : NetworkMessage
{

public const uint Id = 979;
public override uint MessageId
{
    get { return Id; }
}

public short cellX;
        public short cellY;
        

public GameMapNoMovementMessage()
{
}

public GameMapNoMovementMessage(short cellX, short cellY)
        {
            this.cellX = cellX;
            this.cellY = cellY;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(cellX);
            writer.WriteShort(cellY);
            

}

public override void Deserialize(IDataReader reader)
{

cellX = reader.ReadShort();
            cellY = reader.ReadShort();
            

}


}


}