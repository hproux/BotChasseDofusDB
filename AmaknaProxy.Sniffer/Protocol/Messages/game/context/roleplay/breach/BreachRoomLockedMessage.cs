


















// Generated on 02/17/2023 18:45:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class BreachRoomLockedMessage : NetworkMessage
{

public const uint Id = 1319;
public override uint MessageId
{
    get { return Id; }
}



public BreachRoomLockedMessage()
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