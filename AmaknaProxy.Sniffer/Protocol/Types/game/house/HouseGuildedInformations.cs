


















// Generated on 02/22/2023 19:13:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class HouseGuildedInformations : HouseInstanceInformations
{

public const short Id = 8503;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        

public HouseGuildedInformations()
{
}

public HouseGuildedInformations(bool secondHand, bool isLocked, bool hasOwner, bool isSaleLocked, bool isAdminLocked, int instanceId, Types.AccountTagInformation ownerTag, double price, Types.GuildInformations guildInfo)
         : base(secondHand, isLocked, hasOwner, isSaleLocked, isAdminLocked, instanceId, ownerTag, price)
        {
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}