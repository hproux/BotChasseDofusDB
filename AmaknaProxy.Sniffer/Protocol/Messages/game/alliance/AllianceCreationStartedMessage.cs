


















// Generated on 02/17/2023 18:45:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AllianceCreationStartedMessage : NetworkMessage
{

public const uint Id = 8910;
public override uint MessageId
{
    get { return Id; }
}



public AllianceCreationStartedMessage()
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