


















// Generated on 02/17/2023 18:45:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 2230;
public override uint MessageId
{
    get { return Id; }
}

public bool allowed;
        

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
        {
            this.allowed = allowed;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(allowed);
            

}

public override void Deserialize(IDataReader reader)
{

allowed = reader.ReadBoolean();
            

}


}


}