


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameDataPaddockObjectAddMessage : NetworkMessage
{

public const uint Id = 8040;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockItem paddockItemDescription;
        

public GameDataPaddockObjectAddMessage()
{
}

public GameDataPaddockObjectAddMessage(Types.PaddockItem paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        

public override void Serialize(IDataWriter writer)
{

paddockItemDescription.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

paddockItemDescription = new Types.PaddockItem();
            paddockItemDescription.Deserialize(reader);
            

}


}


}