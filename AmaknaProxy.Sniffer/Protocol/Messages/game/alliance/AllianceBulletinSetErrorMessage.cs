


















// Generated on 02/22/2023 19:13:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AllianceBulletinSetErrorMessage : SocialNoticeSetErrorMessage
{

public const uint Id = 745;
public override uint MessageId
{
    get { return Id; }
}



public AllianceBulletinSetErrorMessage()
{
}

public AllianceBulletinSetErrorMessage(sbyte reason)
         : base(reason)
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