


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ShortcutBarSwapRequestMessage : NetworkMessage
{

public const uint Id = 5362;
public override uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public sbyte firstSlot;
        public sbyte secondSlot;
        

public ShortcutBarSwapRequestMessage()
{
}

public ShortcutBarSwapRequestMessage(sbyte barType, sbyte firstSlot, sbyte secondSlot)
        {
            this.barType = barType;
            this.firstSlot = firstSlot;
            this.secondSlot = secondSlot;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(barType);
            writer.WriteSbyte(firstSlot);
            writer.WriteSbyte(secondSlot);
            

}

public override void Deserialize(IDataReader reader)
{

barType = reader.ReadSbyte();
            firstSlot = reader.ReadSbyte();
            secondSlot = reader.ReadSbyte();
            

}


}


}