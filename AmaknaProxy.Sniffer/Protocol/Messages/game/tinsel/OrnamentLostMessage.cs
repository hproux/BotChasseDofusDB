


















// Generated on 02/17/2023 18:45:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class OrnamentLostMessage : NetworkMessage
{

public const uint Id = 7671;
public override uint MessageId
{
    get { return Id; }
}

public short ornamentId;
        

public OrnamentLostMessage()
{
}

public OrnamentLostMessage(short ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(ornamentId);
            

}

public override void Deserialize(IDataReader reader)
{

ornamentId = reader.ReadShort();
            

}


}


}