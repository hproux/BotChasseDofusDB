


















// Generated on 02/22/2023 19:13:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ObjectDeletedMessage : NetworkMessage
{

public const uint Id = 409;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        

public ObjectDeletedMessage()
{
}

public ObjectDeletedMessage(uint objectUID)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            

}


}


}