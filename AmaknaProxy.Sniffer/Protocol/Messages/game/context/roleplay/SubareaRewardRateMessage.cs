


















// Generated on 02/22/2023 19:13:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class SubareaRewardRateMessage : NetworkMessage
{

public const uint Id = 7737;
public override uint MessageId
{
    get { return Id; }
}

public int subAreaRate;
        

public SubareaRewardRateMessage()
{
}

public SubareaRewardRateMessage(int subAreaRate)
        {
            this.subAreaRate = subAreaRate;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaRate);
            

}

public override void Deserialize(IDataReader reader)
{

subAreaRate = reader.ReadVarShort();
            

}


}


}