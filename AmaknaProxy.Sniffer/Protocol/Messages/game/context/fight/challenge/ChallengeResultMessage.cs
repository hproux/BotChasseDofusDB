


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ChallengeResultMessage : NetworkMessage
{

public const uint Id = 8340;
public override uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        public bool success;
        

public ChallengeResultMessage()
{
}

public ChallengeResultMessage(uint challengeId, bool success)
        {
            this.challengeId = challengeId;
            this.success = success;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            writer.WriteBoolean(success);
            

}

public override void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            success = reader.ReadBoolean();
            

}


}


}