


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ActivityLockRequestMessage : NetworkMessage
{

public const uint Id = 3730;
public override uint MessageId
{
    get { return Id; }
}

public uint activityId;
        public bool lockTest;
        

public ActivityLockRequestMessage()
{
}

public ActivityLockRequestMessage(uint activityId, bool lockTest)
        {
            this.activityId = activityId;
            this.lockTest = lockTest;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)activityId);
            writer.WriteBoolean(lockTest);
            

}

public override void Deserialize(IDataReader reader)
{

activityId = reader.ReadVarUhShort();
            lockTest = reader.ReadBoolean();
            

}


}


}