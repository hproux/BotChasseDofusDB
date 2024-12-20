


















// Generated on 02/22/2023 19:13:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MoodSmileyUpdateMessage : NetworkMessage
{

public const uint Id = 2215;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public double playerId;
        public uint smileyId;
        

public MoodSmileyUpdateMessage()
{
}

public MoodSmileyUpdateMessage(int accountId, double playerId, uint smileyId)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.smileyId = smileyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteVarLong(playerId);
            writer.WriteVarShort((int)smileyId);
            

}

public override void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            playerId = reader.ReadVarUhLong();
            smileyId = reader.ReadVarUhShort();
            

}


}


}