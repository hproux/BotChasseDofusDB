


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class NicknameChoiceRequestMessage : NetworkMessage
{

public const uint Id = 9416;
public override uint MessageId
{
    get { return Id; }
}

public string nickname;
        

public NicknameChoiceRequestMessage()
{
}

public NicknameChoiceRequestMessage(string nickname)
        {
            this.nickname = nickname;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(nickname);
            

}

public override void Deserialize(IDataReader reader)
{

nickname = reader.ReadUTF();
            

}


}


}