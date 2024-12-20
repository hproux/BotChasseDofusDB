


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameActionFightCastOnTargetRequestMessage : NetworkMessage
{

public const uint Id = 270;
public override uint MessageId
{
    get { return Id; }
}

public uint spellId;
        public double targetId;
        

public GameActionFightCastOnTargetRequestMessage()
{
}

public GameActionFightCastOnTargetRequestMessage(uint spellId, double targetId)
        {
            this.spellId = spellId;
            this.targetId = targetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            writer.WriteDouble(targetId);
            

}

public override void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
            

}


}


}