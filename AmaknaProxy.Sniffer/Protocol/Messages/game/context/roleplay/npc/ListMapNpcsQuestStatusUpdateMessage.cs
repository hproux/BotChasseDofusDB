


















// Generated on 02/17/2023 18:45:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ListMapNpcsQuestStatusUpdateMessage : NetworkMessage
{

public const uint Id = 2320;
public override uint MessageId
{
    get { return Id; }
}

public Types.MapNpcQuestInfo[] mapInfo;
        

public ListMapNpcsQuestStatusUpdateMessage()
{
}

public ListMapNpcsQuestStatusUpdateMessage(Types.MapNpcQuestInfo[] mapInfo)
        {
            this.mapInfo = mapInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)mapInfo.Length);
            foreach (var entry in mapInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            mapInfo = new Types.MapNpcQuestInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 mapInfo[i] = new Types.MapNpcQuestInfo();
                 mapInfo[i].Deserialize(reader);
            }
            

}


}


}