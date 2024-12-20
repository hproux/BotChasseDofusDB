


















// Generated on 02/22/2023 19:13:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CompassUpdateMessage : NetworkMessage
{

public const uint Id = 7989;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public Types.MapCoordinates coords;
        

public CompassUpdateMessage()
{
}

public CompassUpdateMessage(sbyte type, Types.MapCoordinates coords)
        {
            this.type = type;
            this.coords = coords;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteShort(coords.TypeId);
            coords.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            coords = ProtocolTypeManager.GetInstance<Types.MapCoordinates>(reader.ReadUShort());
            coords.Deserialize(reader);
            

}


}


}