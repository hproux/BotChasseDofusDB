


















// Generated on 02/17/2023 18:45:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CharacterLevelUpMessage : NetworkMessage
{

public const uint Id = 1846;
public override uint MessageId
{
    get { return Id; }
}

public uint newLevel;
        

public CharacterLevelUpMessage()
{
}

public CharacterLevelUpMessage(uint newLevel)
        {
            this.newLevel = newLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)newLevel);
            

}

public override void Deserialize(IDataReader reader)
{

newLevel = reader.ReadVarUhShort();
            

}


}


}