


















// Generated on 02/22/2023 19:13:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
{

public const uint Id = 4807;
public override uint MessageId
{
    get { return Id; }
}

public uint spellId;
        

public GameActionFightDispellSpellMessage()
{
}

public GameActionFightDispellSpellMessage(uint actionId, double sourceId, double targetId, bool verboseCast, uint spellId)
         : base(actionId, sourceId, targetId, verboseCast)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)spellId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
            

}


}


}