


















// Generated on 02/22/2023 19:13:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MapFightStartPositionsUpdateMessage : NetworkMessage
{

public const uint Id = 8655;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public Types.FightStartingPositions fightStartPositions;
        

public MapFightStartPositionsUpdateMessage()
{
}

public MapFightStartPositionsUpdateMessage(double mapId, Types.FightStartingPositions fightStartPositions)
        {
            this.mapId = mapId;
            this.fightStartPositions = fightStartPositions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            fightStartPositions.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            fightStartPositions = new Types.FightStartingPositions();
            fightStartPositions.Deserialize(reader);
            

}


}


}