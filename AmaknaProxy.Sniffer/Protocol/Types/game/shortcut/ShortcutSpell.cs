


















// Generated on 02/22/2023 19:13:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class ShortcutSpell : Shortcut
{

public const short Id = 8571;
public override short TypeId
{
    get { return Id; }
}

public uint spellId;
        

public ShortcutSpell()
{
}

public ShortcutSpell(sbyte slot, uint spellId)
         : base(slot)
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