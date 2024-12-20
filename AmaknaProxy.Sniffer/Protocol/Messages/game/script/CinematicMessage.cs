


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CinematicMessage : NetworkMessage
{

public const uint Id = 8039;
public override uint MessageId
{
    get { return Id; }
}

public uint cinematicId;
        

public CinematicMessage()
{
}

public CinematicMessage(uint cinematicId)
        {
            this.cinematicId = cinematicId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cinematicId);
            

}

public override void Deserialize(IDataReader reader)
{

cinematicId = reader.ReadVarUhShort();
            

}


}


}