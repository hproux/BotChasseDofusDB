


















// Generated on 02/22/2023 19:13:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MapFightCountMessage : NetworkMessage
{

public const uint Id = 5031;
public override uint MessageId
{
    get { return Id; }
}

public uint fightCount;
        

public MapFightCountMessage()
{
}

public MapFightCountMessage(uint fightCount)
        {
            this.fightCount = fightCount;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightCount);
            

}

public override void Deserialize(IDataReader reader)
{

fightCount = reader.ReadVarUhShort();
            

}


}


}