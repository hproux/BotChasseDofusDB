


















// Generated on 02/17/2023 18:45:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MountSterilizeRequestMessage : NetworkMessage
{

public const uint Id = 3278;
public override uint MessageId
{
    get { return Id; }
}



public MountSterilizeRequestMessage()
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