


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PrismFightJoinLeaveRequestMessage : NetworkMessage
{

public const uint Id = 317;
public override uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public bool join;
        

public PrismFightJoinLeaveRequestMessage()
{
}

public PrismFightJoinLeaveRequestMessage(uint subAreaId, bool join)
        {
            this.subAreaId = subAreaId;
            this.join = join;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteBoolean(join);
            

}

public override void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            join = reader.ReadBoolean();
            

}


}


}