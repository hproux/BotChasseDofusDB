


















// Generated on 02/17/2023 18:45:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CharacterCanBeCreatedResultMessage : NetworkMessage
{

public const uint Id = 7681;
public override uint MessageId
{
    get { return Id; }
}

public bool yesYouCan;
        

public CharacterCanBeCreatedResultMessage()
{
}

public CharacterCanBeCreatedResultMessage(bool yesYouCan)
        {
            this.yesYouCan = yesYouCan;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(yesYouCan);
            

}

public override void Deserialize(IDataReader reader)
{

yesYouCan = reader.ReadBoolean();
            

}


}


}