


















// Generated on 02/22/2023 19:13:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GoldAddedMessage : NetworkMessage
{

public const uint Id = 6234;
public override uint MessageId
{
    get { return Id; }
}

public Types.GoldItem gold;
        

public GoldAddedMessage()
{
}

public GoldAddedMessage(Types.GoldItem gold)
        {
            this.gold = gold;
        }
        

public override void Serialize(IDataWriter writer)
{

gold.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

gold = new Types.GoldItem();
            gold.Deserialize(reader);
            

}


}


}