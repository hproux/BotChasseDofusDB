


















// Generated on 02/22/2023 19:13:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CompassUpdatePvpSeekMessage : CompassUpdateMessage
{

public const uint Id = 3141;
public override uint MessageId
{
    get { return Id; }
}

public double memberId;
        public string memberName;
        

public CompassUpdatePvpSeekMessage()
{
}

public CompassUpdatePvpSeekMessage(sbyte type, Types.MapCoordinates coords, double memberId, string memberName)
         : base(type, coords)
        {
            this.memberId = memberId;
            this.memberName = memberName;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(memberId);
            writer.WriteUTF(memberName);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            memberId = reader.ReadVarUhLong();
            memberName = reader.ReadUTF();
            

}


}


}