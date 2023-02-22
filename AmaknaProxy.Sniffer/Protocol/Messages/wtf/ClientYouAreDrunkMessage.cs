


















// Generated on 02/22/2023 19:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ClientYouAreDrunkMessage : DebugInClientMessage
{

public const uint Id = 9532;
public override uint MessageId
{
    get { return Id; }
}



public ClientYouAreDrunkMessage()
{
}

public ClientYouAreDrunkMessage(sbyte level, string message)
         : base(level, message)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}