


















// Generated on 02/22/2023 19:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class HaapiConsumeBufferRequestMessage : NetworkMessage
{

public const uint Id = 2453;
public override uint MessageId
{
    get { return Id; }
}



public HaapiConsumeBufferRequestMessage()
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