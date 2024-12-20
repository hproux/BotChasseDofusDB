


















// Generated on 02/22/2023 19:13:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TeleportToBuddyCloseMessage : NetworkMessage
{

public const uint Id = 479;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public double buddyId;
        

public TeleportToBuddyCloseMessage()
{
}

public TeleportToBuddyCloseMessage(uint dungeonId, double buddyId)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(buddyId);
            

}

public override void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            buddyId = reader.ReadVarUhLong();
            

}


}


}