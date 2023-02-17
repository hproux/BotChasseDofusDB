


















// Generated on 02/17/2023 18:45:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameContextRemoveElementMessage : NetworkMessage
{

public const uint Id = 2866;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        

public GameContextRemoveElementMessage()
{
}

public GameContextRemoveElementMessage(double id)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            

}


}


}