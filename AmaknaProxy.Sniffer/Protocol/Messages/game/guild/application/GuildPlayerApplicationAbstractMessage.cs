


















// Generated on 02/22/2023 19:13:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildPlayerApplicationAbstractMessage : NetworkMessage
{

public const uint Id = 1538;
public override uint MessageId
{
    get { return Id; }
}



public GuildPlayerApplicationAbstractMessage()
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