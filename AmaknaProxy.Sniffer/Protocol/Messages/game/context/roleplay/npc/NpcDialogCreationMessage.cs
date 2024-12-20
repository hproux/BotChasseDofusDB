


















// Generated on 02/22/2023 19:13:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class NpcDialogCreationMessage : NetworkMessage
{

public const uint Id = 6164;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public int npcId;
        

public NpcDialogCreationMessage()
{
}

public NpcDialogCreationMessage(double mapId, int npcId)
        {
            this.mapId = mapId;
            this.npcId = npcId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteInt(npcId);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            npcId = reader.ReadInt();
            

}


}


}