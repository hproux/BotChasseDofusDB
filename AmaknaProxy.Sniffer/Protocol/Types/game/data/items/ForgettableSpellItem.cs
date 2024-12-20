


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class ForgettableSpellItem : SpellItem
{

public const short Id = 650;
public override short TypeId
{
    get { return Id; }
}

public bool available;
        

public ForgettableSpellItem()
{
}

public ForgettableSpellItem(int spellId, short spellLevel, bool available)
         : base(spellId, spellLevel)
        {
            this.available = available;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(available);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            available = reader.ReadBoolean();
            

}


}


}