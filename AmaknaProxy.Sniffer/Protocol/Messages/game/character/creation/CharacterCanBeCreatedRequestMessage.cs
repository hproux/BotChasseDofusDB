


















// Generated on 02/17/2023 18:45:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CharacterCanBeCreatedRequestMessage : NetworkMessage
{

public const uint Id = 5623;
public override uint MessageId
{
    get { return Id; }
}



public CharacterCanBeCreatedRequestMessage()
{
}



public override void Serialize(IDataWriter writer)
{



}

public override void Deserialize(IDataReader reader)
{



}


}


}