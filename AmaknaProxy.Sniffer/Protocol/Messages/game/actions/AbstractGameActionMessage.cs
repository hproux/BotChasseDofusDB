


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AbstractGameActionMessage : NetworkMessage
{

public const uint Id = 2888;
public override uint MessageId
{
    get { return Id; }
}

public uint actionId;
        public double sourceId;
        

public AbstractGameActionMessage()
{
}

public AbstractGameActionMessage(uint actionId, double sourceId)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            writer.WriteDouble(sourceId);
            

}

public override void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            sourceId = reader.ReadDouble();
            

}


}


}