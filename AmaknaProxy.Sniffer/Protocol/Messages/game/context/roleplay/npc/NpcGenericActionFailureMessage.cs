


















// Generated on 02/17/2023 18:45:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class NpcGenericActionFailureMessage : NetworkMessage
{

public const uint Id = 9872;
public override uint MessageId
{
    get { return Id; }
}



public NpcGenericActionFailureMessage()
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