


















// Generated on 02/22/2023 19:13:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
{

public const short Id = 1595;
public override short TypeId
{
    get { return Id; }
}

public int delta;
        

public FightTemporaryBoostEffect()
{
}

public FightTemporaryBoostEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, uint spellId, uint effectId, uint parentBoostUid, int delta)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
        {
            this.delta = delta;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(delta);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            delta = reader.ReadInt();
            

}


}


}