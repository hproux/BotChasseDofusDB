


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GuildUnlockNewTabActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 7590;
public override short TypeId
{
    get { return Id; }
}



public GuildUnlockNewTabActivity()
{
}

public GuildUnlockNewTabActivity(uint id, double date)
         : base(id, date)
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