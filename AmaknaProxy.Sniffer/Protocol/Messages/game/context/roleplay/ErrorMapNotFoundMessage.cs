


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ErrorMapNotFoundMessage : NetworkMessage
{

public const uint Id = 6990;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        

public ErrorMapNotFoundMessage()
{
}

public ErrorMapNotFoundMessage(double mapId)
        {
            this.mapId = mapId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            

}


}


}