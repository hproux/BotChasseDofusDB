


















// Generated on 02/22/2023 19:13:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
{

public const uint Id = 6024;
public override uint MessageId
{
    get { return Id; }
}

public double memberId;
        public bool active;
        

public CompassUpdatePartyMemberMessage()
{
}

public CompassUpdatePartyMemberMessage(sbyte type, Types.MapCoordinates coords, double memberId, bool active)
         : base(type, coords)
        {
            this.memberId = memberId;
            this.active = active;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(memberId);
            writer.WriteBoolean(active);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            memberId = reader.ReadVarUhLong();
            active = reader.ReadBoolean();
            

}


}


}