


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class OrnamentSelectedMessage : NetworkMessage
{

public const uint Id = 2070;
public override uint MessageId
{
    get { return Id; }
}

public uint ornamentId;
        

public OrnamentSelectedMessage()
{
}

public OrnamentSelectedMessage(uint ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)ornamentId);
            

}

public override void Deserialize(IDataReader reader)
{

ornamentId = reader.ReadVarUhShort();
            

}


}


}