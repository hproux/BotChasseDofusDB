


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PaddockRemoveItemRequestMessage : NetworkMessage
{

public const uint Id = 1817;
public override uint MessageId
{
    get { return Id; }
}

public uint cellId;
        

public PaddockRemoveItemRequestMessage()
{
}

public PaddockRemoveItemRequestMessage(uint cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            

}

public override void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            

}


}


}