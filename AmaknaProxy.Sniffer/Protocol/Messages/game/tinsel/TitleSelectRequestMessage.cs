


















// Generated on 02/17/2023 18:45:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TitleSelectRequestMessage : NetworkMessage
{

public const uint Id = 6160;
public override uint MessageId
{
    get { return Id; }
}

public uint titleId;
        

public TitleSelectRequestMessage()
{
}

public TitleSelectRequestMessage(uint titleId)
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