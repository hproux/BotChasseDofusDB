


















// Generated on 02/22/2023 19:13:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TaxCollectorMovementAddMessage : NetworkMessage
{

public const uint Id = 9034;
public override uint MessageId
{
    get { return Id; }
}

public Types.TaxCollectorInformations informations;
        

public TaxCollectorMovementAddMessage()
{
}

public TaxCollectorMovementAddMessage(Types.TaxCollectorInformations informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

informations = ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
            

}


}


}