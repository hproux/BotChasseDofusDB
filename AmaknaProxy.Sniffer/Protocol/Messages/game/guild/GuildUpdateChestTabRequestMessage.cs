


















// Generated on 02/17/2023 18:45:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildUpdateChestTabRequestMessage : NetworkMessage
{

public const uint Id = 5668;
public override uint MessageId
{
    get { return Id; }
}

public Types.UpdatedStorageTabInformation tab;
        

public GuildUpdateChestTabRequestMessage()
{
}

public GuildUpdateChestTabRequestMessage(Types.UpdatedStorageTabInformation tab)
        {
            this.tab = tab;
        }
        

public override void Serialize(IDataWriter writer)
{

tab.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

tab = new Types.UpdatedStorageTabInformation();
            tab.Deserialize(reader);
            

}


}


}