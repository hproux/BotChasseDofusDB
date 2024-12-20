


















// Generated on 02/22/2023 19:13:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ObjectGroundRemovedMultipleMessage : NetworkMessage
{

public const uint Id = 1062;
public override uint MessageId
{
    get { return Id; }
}

public uint[] cells;
        

public ObjectGroundRemovedMultipleMessage()
{
}

public ObjectGroundRemovedMultipleMessage(uint[] cells)
        {
            this.cells = cells;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            cells = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadVarUhShort();
            }
            

}


}


}