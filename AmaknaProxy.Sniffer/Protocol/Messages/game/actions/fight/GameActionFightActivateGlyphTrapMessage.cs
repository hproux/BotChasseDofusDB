


















// Generated on 02/22/2023 19:13:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameActionFightActivateGlyphTrapMessage : AbstractGameActionMessage
{

public const uint Id = 4325;
public override uint MessageId
{
    get { return Id; }
}

public short markId;
        public bool active;
        

public GameActionFightActivateGlyphTrapMessage()
{
}

public GameActionFightActivateGlyphTrapMessage(uint actionId, double sourceId, short markId, bool active)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.active = active;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteBoolean(active);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            markId = reader.ReadShort();
            active = reader.ReadBoolean();
            

}


}


}