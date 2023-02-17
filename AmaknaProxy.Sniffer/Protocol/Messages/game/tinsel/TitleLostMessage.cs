


















// Generated on 02/17/2023 18:45:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TitleLostMessage : NetworkMessage
{

public const uint Id = 5921;
public override uint MessageId
{
    get { return Id; }
}

public uint titleId;
        

public TitleLostMessage()
{
}

public TitleLostMessage(uint titleId)
        {
            this.titleId = titleId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)titleId);
            

}

public override void Deserialize(IDataReader reader)
{

titleId = reader.ReadVarUhShort();
            

}


}


}