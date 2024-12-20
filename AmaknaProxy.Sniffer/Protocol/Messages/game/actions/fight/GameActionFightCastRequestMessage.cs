


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameActionFightCastRequestMessage : NetworkMessage
{

public const uint Id = 3791;
public override uint MessageId
{
    get { return Id; }
}

public uint spellId;
        public short cellId;
        

public GameActionFightCastRequestMessage()
{
}

public GameActionFightCastRequestMessage(uint spellId, short cellId)
        {
            this.spellId = spellId;
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            cellId = reader.ReadShort();
            

}


}


}