


















// Generated on 02/22/2023 19:13:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class HumanOptionFollowers : HumanOption
{

public const short Id = 5290;
public override short TypeId
{
    get { return Id; }
}

public Types.IndexedEntityLook[] followingCharactersLook;
        

public HumanOptionFollowers()
{
}

public HumanOptionFollowers(Types.IndexedEntityLook[] followingCharactersLook)
        {
            this.followingCharactersLook = followingCharactersLook;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)followingCharactersLook.Length);
            foreach (var entry in followingCharactersLook)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            followingCharactersLook = new Types.IndexedEntityLook[limit];
            for (int i = 0; i < limit; i++)
            {
                 followingCharactersLook[i] = new Types.IndexedEntityLook();
                 followingCharactersLook[i].Deserialize(reader);
            }
            

}


}


}