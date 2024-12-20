


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CurrentMapInstanceMessage : CurrentMapMessage
{

public const uint Id = 4457;
public override uint MessageId
{
    get { return Id; }
}

public double instantiatedMapId;
        

public CurrentMapInstanceMessage()
{
}

public CurrentMapInstanceMessage(double mapId, double instantiatedMapId)
         : base(mapId)
        {
            this.instantiatedMapId = instantiatedMapId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(instantiatedMapId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            instantiatedMapId = reader.ReadDouble();
            

}


}


}