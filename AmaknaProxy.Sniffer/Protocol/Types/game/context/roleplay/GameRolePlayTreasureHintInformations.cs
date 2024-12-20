


















// Generated on 02/22/2023 19:13:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
{

public const short Id = 2825;
public override short TypeId
{
    get { return Id; }
}

public uint npcId;
        

public GameRolePlayTreasureHintInformations()
{
}

public GameRolePlayTreasureHintInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, uint npcId)
         : base(contextualId, disposition, look)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)npcId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            npcId = reader.ReadVarUhShort();
            

}


}


}