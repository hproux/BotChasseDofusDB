


















// Generated on 02/22/2023 19:13:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 3047;
public override uint MessageId
{
    get { return Id; }
}

public bool allow;
        

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
        {
            this.allow = allow;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(allow);
            

}

public override void Deserialize(IDataReader reader)
{

allow = reader.ReadBoolean();
            

}


}


}