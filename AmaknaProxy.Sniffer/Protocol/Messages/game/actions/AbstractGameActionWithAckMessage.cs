


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
{

public const uint Id = 240;
public override uint MessageId
{
    get { return Id; }
}

public short waitAckId;
        

public AbstractGameActionWithAckMessage()
{
}

public AbstractGameActionWithAckMessage(uint actionId, double sourceId, short waitAckId)
         : base(actionId, sourceId)
        {
            this.waitAckId = waitAckId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(waitAckId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            waitAckId = reader.ReadShort();
            

}


}


}