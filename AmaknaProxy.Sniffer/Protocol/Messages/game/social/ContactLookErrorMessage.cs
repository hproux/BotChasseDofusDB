


















// Generated on 02/17/2023 18:45:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ContactLookErrorMessage : NetworkMessage
{

public const uint Id = 9005;
public override uint MessageId
{
    get { return Id; }
}

public uint requestId;
        

public ContactLookErrorMessage()
{
}

public ContactLookErrorMessage(uint requestId)
        {
            this.requestId = requestId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)requestId);
            

}

public override void Deserialize(IDataReader reader)
{

requestId = reader.ReadVarUhInt();
            

}


}


}