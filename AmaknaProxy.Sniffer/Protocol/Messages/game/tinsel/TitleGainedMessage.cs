


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TitleGainedMessage : NetworkMessage
{

public const uint Id = 7718;
public override uint MessageId
{
    get { return Id; }
}

public uint titleId;
        

public TitleGainedMessage()
{
}

public TitleGainedMessage(uint titleId)
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