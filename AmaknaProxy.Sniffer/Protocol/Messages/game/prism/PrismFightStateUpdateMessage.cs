


















// Generated on 02/22/2023 19:13:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PrismFightStateUpdateMessage : NetworkMessage
{

public const uint Id = 7030;
public override uint MessageId
{
    get { return Id; }
}

public sbyte state;
        

public PrismFightStateUpdateMessage()
{
}

public PrismFightStateUpdateMessage(sbyte state)
        {
            this.state = state;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(state);
            

}

public override void Deserialize(IDataReader reader)
{

state = reader.ReadSbyte();
            

}


}


}