


















// Generated on 02/17/2023 18:45:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TeleportToBuddyOfferMessage : NetworkMessage
{

public const uint Id = 1620;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public double buddyId;
        public uint timeLeft;
        

public TeleportToBuddyOfferMessage()
{
}

public TeleportToBuddyOfferMessage(uint dungeonId, double buddyId, uint timeLeft)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.timeLeft = timeLeft;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(buddyId);
            writer.WriteVarInt((int)timeLeft);
            

}

public override void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            buddyId = reader.ReadVarUhLong();
            timeLeft = reader.ReadVarUhInt();
            

}


}


}