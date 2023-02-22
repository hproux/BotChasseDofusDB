


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ActivityHideRequestMessage : NetworkMessage
{

public const uint Id = 990;
public override uint MessageId
{
    get { return Id; }
}

public uint activityId;
        

public ActivityHideRequestMessage()
{
}

public ActivityHideRequestMessage(uint activityId)
        {
            this.activityId = activityId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)activityId);
            

}

public override void Deserialize(IDataReader reader)
{

activityId = reader.ReadVarUhShort();
            

}


}


}