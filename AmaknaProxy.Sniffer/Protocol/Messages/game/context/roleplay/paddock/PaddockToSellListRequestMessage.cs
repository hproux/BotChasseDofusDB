


















// Generated on 02/17/2023 18:45:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PaddockToSellListRequestMessage : NetworkMessage
{

public const uint Id = 7013;
public override uint MessageId
{
    get { return Id; }
}

public uint pageIndex;
        

public PaddockToSellListRequestMessage()
{
}

public PaddockToSellListRequestMessage(uint pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)pageIndex);
            

}

public override void Deserialize(IDataReader reader)
{

pageIndex = reader.ReadVarUhShort();
            

}


}


}