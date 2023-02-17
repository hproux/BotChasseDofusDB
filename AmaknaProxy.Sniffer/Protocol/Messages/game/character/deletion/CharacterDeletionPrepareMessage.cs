


















// Generated on 02/17/2023 18:45:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CharacterDeletionPrepareMessage : NetworkMessage
{

public const uint Id = 9781;
public override uint MessageId
{
    get { return Id; }
}

public double characterId;
        public string characterName;
        public string secretQuestion;
        public bool needSecretAnswer;
        

public CharacterDeletionPrepareMessage()
{
}

public CharacterDeletionPrepareMessage(double characterId, string characterName, string secretQuestion, bool needSecretAnswer)
        {
            this.characterId = characterId;
            this.characterName = characterName;
            this.secretQuestion = secretQuestion;
            this.needSecretAnswer = needSecretAnswer;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            writer.WriteUTF(characterName);
            writer.WriteUTF(secretQuestion);
            writer.WriteBoolean(needSecretAnswer);
            

}

public override void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            characterName = reader.ReadUTF();
            secretQuestion = reader.ReadUTF();
            needSecretAnswer = reader.ReadBoolean();
            

}


}


}