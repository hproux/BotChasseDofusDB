


















// Generated on 02/22/2023 19:13:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class PlayerSearchCharacterNameInformation : AbstractPlayerSearchInformation
{

public const short Id = 4980;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public PlayerSearchCharacterNameInformation()
{
}

public PlayerSearchCharacterNameInformation(string name)
        {
            this.name = name;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}