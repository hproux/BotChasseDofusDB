


















// Generated on 02/22/2023 19:13:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class DungeonPartyFinderListenRequestMessage : NetworkMessage
{

public const uint Id = 7978;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        

public DungeonPartyFinderListenRequestMessage()
{
}

public DungeonPartyFinderListenRequestMessage(uint dungeonId)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            

}

public override void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            

}


}


}