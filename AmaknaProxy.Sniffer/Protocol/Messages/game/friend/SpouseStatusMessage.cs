


















// Generated on 02/17/2023 18:45:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class SpouseStatusMessage : NetworkMessage
{

public const uint Id = 1835;
public override uint MessageId
{
    get { return Id; }
}

public bool hasSpouse;
        

public SpouseStatusMessage()
{
}

public SpouseStatusMessage(bool hasSpouse)
        {
            this.hasSpouse = hasSpouse;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(hasSpouse);
            

}

public override void Deserialize(IDataReader reader)
{

hasSpouse = reader.ReadBoolean();
            

}


}


}