


















// Generated on 02/22/2023 19:13:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CharacterSelectedForceMessage : NetworkMessage
{

public const uint Id = 3433;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public CharacterSelectedForceMessage()
{
}

public CharacterSelectedForceMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadInt();
            

}


}


}