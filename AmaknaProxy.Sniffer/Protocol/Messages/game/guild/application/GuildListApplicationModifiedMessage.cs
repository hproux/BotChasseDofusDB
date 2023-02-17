


















// Generated on 02/17/2023 18:45:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GuildListApplicationModifiedMessage : NetworkMessage
{

public const uint Id = 4960;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildApplicationInformation apply;
        public sbyte state;
        public double playerId;
        

public GuildListApplicationModifiedMessage()
{
}

public GuildListApplicationModifiedMessage(Types.GuildApplicationInformation apply, sbyte state, double playerId)
        {
            this.apply = apply;
            this.state = state;
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

apply.Serialize(writer);
            writer.WriteSbyte(state);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

apply = new Types.GuildApplicationInformation();
            apply.Deserialize(reader);
            state = reader.ReadSbyte();
            playerId = reader.ReadVarUhLong();
            

}


}


}