


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class IgnoredInformations : AbstractContactInformations
{

public const short Id = 3964;
public override short TypeId
{
    get { return Id; }
}



public IgnoredInformations()
{
}

public IgnoredInformations(int accountId, Types.AccountTagInformation accountTag)
         : base(accountId, accountTag)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}