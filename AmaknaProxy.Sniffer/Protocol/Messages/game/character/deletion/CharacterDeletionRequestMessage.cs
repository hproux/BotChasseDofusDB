


















// Generated on 02/22/2023 19:13:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CharacterDeletionRequestMessage : NetworkMessage
{

public const uint Id = 6311;
public override uint MessageId
{
    get { return Id; }
}

public double characterId;
        public string secretAnswerHash;
        

public CharacterDeletionRequestMessage()
{
}

public CharacterDeletionRequestMessage(double characterId, string secretAnswerHash)
        {
            this.characterId = characterId;
            this.secretAnswerHash = secretAnswerHash;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            writer.WriteUTF(secretAnswerHash);
            

}

public override void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            secretAnswerHash = reader.ReadUTF();
            

}


}


}