


















// Generated on 02/22/2023 19:13:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CharactersListRequestMessage : NetworkMessage
{

public const uint Id = 1659;
public override uint MessageId
{
    get { return Id; }
}



public CharactersListRequestMessage()
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