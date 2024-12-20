


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class FightResultListEntry
{

public const short Id = 676;
public virtual short TypeId
{
    get { return Id; }
}

public uint outcome;
        public sbyte wave;
        public Types.FightLoot rewards;
        

public FightResultListEntry()
{
}

public FightResultListEntry(uint outcome, sbyte wave, Types.FightLoot rewards)
        {
            this.outcome = outcome;
            this.wave = wave;
            this.rewards = rewards;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)outcome);
            writer.WriteSbyte(wave);
            rewards.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

outcome = reader.ReadVarUhShort();
            wave = reader.ReadSbyte();
            rewards = new Types.FightLoot();
            rewards.Deserialize(reader);
            

}


}


}