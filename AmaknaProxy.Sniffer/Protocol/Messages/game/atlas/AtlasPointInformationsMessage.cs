


















// Generated on 02/22/2023 19:13:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AtlasPointInformationsMessage : NetworkMessage
{

public const uint Id = 7346;
public override uint MessageId
{
    get { return Id; }
}

public Types.AtlasPointsInformations type;
        

public AtlasPointInformationsMessage()
{
}

public AtlasPointInformationsMessage(Types.AtlasPointsInformations type)
        {
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

type.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

type = new Types.AtlasPointsInformations();
            type.Deserialize(reader);
            

}


}


}