


















// Generated on 02/17/2023 18:45:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PrismInfoCloseMessage : NetworkMessage
{

public const uint Id = 9471;
public override uint MessageId
{
    get { return Id; }
}



public PrismInfoCloseMessage()
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