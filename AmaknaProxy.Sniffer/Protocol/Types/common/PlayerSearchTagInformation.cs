


















// Generated on 02/22/2023 19:13:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class PlayerSearchTagInformation : AbstractPlayerSearchInformation
{

public const short Id = 8414;
public override short TypeId
{
    get { return Id; }
}

public Types.AccountTagInformation tag;
        

public PlayerSearchTagInformation()
{
}

public PlayerSearchTagInformation(Types.AccountTagInformation tag)
        {
            this.tag = tag;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            tag.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
            

}


}


}