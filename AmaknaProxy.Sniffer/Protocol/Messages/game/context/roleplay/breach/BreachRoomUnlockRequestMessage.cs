


















// Generated on 02/22/2023 19:13:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class BreachRoomUnlockRequestMessage : NetworkMessage
{

public const uint Id = 5563;
public override uint MessageId
{
    get { return Id; }
}

public sbyte roomId;
        

public BreachRoomUnlockRequestMessage()
{
}

public BreachRoomUnlockRequestMessage(sbyte roomId)
        {
            this.roomId = roomId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(roomId);
            

}

public override void Deserialize(IDataReader reader)
{

roomId = reader.ReadSbyte();
            

}


}


}