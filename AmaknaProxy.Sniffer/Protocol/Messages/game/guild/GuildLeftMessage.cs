


















// Generated on 02/17/2023 18:45:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildLeftMessage : NetworkMessage
{

public const uint Id = 2350;
public override uint MessageId
{
    get { return Id; }
}



public GuildLeftMessage()
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