


















// Generated on 02/17/2023 18:45:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeLeaveMessage : LeaveDialogMessage
{

public const uint Id = 5737;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        

public ExchangeLeaveMessage()
{
}

public ExchangeLeaveMessage(sbyte dialogType, bool success)
         : base(dialogType)
        {
            this.success = success;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(success);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            success = reader.ReadBoolean();
            

}


}


}