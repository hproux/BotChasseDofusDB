


















// Generated on 02/17/2023 18:45:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ShowCellMessage : NetworkMessage
{

public const uint Id = 4902;
public override uint MessageId
{
    get { return Id; }
}

public double sourceId;
        public uint cellId;
        

public ShowCellMessage()
{
}

public ShowCellMessage(double sourceId, uint cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(sourceId);
            writer.WriteVarShort((int)cellId);
            

}

public override void Deserialize(IDataReader reader)
{

sourceId = reader.ReadDouble();
            cellId = reader.ReadVarUhShort();
            

}


}


}