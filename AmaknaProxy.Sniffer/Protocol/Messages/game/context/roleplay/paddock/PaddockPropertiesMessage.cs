


















// Generated on 02/22/2023 19:13:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PaddockPropertiesMessage : NetworkMessage
{

public const uint Id = 6829;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockInstancesInformations properties;
        

public PaddockPropertiesMessage()
{
}

public PaddockPropertiesMessage(Types.PaddockInstancesInformations properties)
        {
            this.properties = properties;
        }
        

public override void Serialize(IDataWriter writer)
{

properties.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

properties = new Types.PaddockInstancesInformations();
            properties.Deserialize(reader);
            

}


}


}