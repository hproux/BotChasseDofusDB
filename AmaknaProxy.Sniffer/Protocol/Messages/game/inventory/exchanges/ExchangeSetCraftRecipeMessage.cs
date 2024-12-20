


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeSetCraftRecipeMessage : NetworkMessage
{

public const uint Id = 577;
public override uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        

public ExchangeSetCraftRecipeMessage()
{
}

public ExchangeSetCraftRecipeMessage(uint objectGID)
        {
            this.objectGID = objectGID;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectGID);
            

}

public override void Deserialize(IDataReader reader)
{

objectGID = reader.ReadVarUhInt();
            

}


}


}