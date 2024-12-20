


















// Generated on 02/22/2023 19:13:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class BreachRoomUnlockResultMessage : NetworkMessage
{

public const uint Id = 6865;
public override uint MessageId
{
    get { return Id; }
}

public sbyte roomId;
        public sbyte result;
        

public BreachRoomUnlockResultMessage()
{
}

public BreachRoomUnlockResultMessage(sbyte roomId, sbyte result)
        {
            this.roomId = roomId;
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(roomId);
            writer.WriteSbyte(result);
            

}

public override void Deserialize(IDataReader reader)
{

roomId = reader.ReadSbyte();
            result = reader.ReadSbyte();
            

}


}


}