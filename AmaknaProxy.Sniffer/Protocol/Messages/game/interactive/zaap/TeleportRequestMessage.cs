


















// Generated on 02/22/2023 19:13:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class TeleportRequestMessage : NetworkMessage
{

public const uint Id = 8454;
public override uint MessageId
{
    get { return Id; }
}

public sbyte sourceType;
        public sbyte destinationType;
        public double mapId;
        

public TeleportRequestMessage()
{
}

public TeleportRequestMessage(sbyte sourceType, sbyte destinationType, double mapId)
        {
            this.sourceType = sourceType;
            this.destinationType = destinationType;
            this.mapId = mapId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(sourceType);
            writer.WriteSbyte(destinationType);
            writer.WriteDouble(mapId);
            

}

public override void Deserialize(IDataReader reader)
{

sourceType = reader.ReadSbyte();
            destinationType = reader.ReadSbyte();
            mapId = reader.ReadDouble();
            

}


}


}