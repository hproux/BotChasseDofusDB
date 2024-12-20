


















// Generated on 02/22/2023 19:13:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameContextRefreshEntityLookMessage : NetworkMessage
{

public const uint Id = 3848;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        public Types.EntityLook look;
        

public GameContextRefreshEntityLookMessage()
{
}

public GameContextRefreshEntityLookMessage(double id, Types.EntityLook look)
        {
            this.id = id;
            this.look = look;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            look.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}