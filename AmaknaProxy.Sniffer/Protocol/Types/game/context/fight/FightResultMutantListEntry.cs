


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class FightResultMutantListEntry : FightResultFighterListEntry
{

public const short Id = 7849;
public override short TypeId
{
    get { return Id; }
}

public uint level;
        

public FightResultMutantListEntry()
{
}

public FightResultMutantListEntry(uint outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive, uint level)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)level);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            level = reader.ReadVarUhShort();
            

}


}


}