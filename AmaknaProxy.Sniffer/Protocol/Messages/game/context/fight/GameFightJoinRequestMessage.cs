


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightJoinRequestMessage : NetworkMessage
{

public const uint Id = 6094;
public override uint MessageId
{
    get { return Id; }
}

public double fighterId;
        public uint fightId;
        

public GameFightJoinRequestMessage()
{
}

public GameFightJoinRequestMessage(double fighterId, uint fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(fighterId);
            writer.WriteVarShort((int)fightId);
            

}

public override void Deserialize(IDataReader reader)
{

fighterId = reader.ReadDouble();
            fightId = reader.ReadVarUhShort();
            

}


}


}