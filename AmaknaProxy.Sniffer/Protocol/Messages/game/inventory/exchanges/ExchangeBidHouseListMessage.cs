


















// Generated on 02/22/2023 19:13:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeBidHouseListMessage : NetworkMessage
{

public const uint Id = 561;
public override uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        public bool follow;
        

public ExchangeBidHouseListMessage()
{
}

public ExchangeBidHouseListMessage(uint objectGID, bool follow)
        {
            this.objectGID = objectGID;
            this.follow = follow;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectGID);
            writer.WriteBoolean(follow);
            

}

public override void Deserialize(IDataReader reader)
{

objectGID = reader.ReadVarUhInt();
            follow = reader.ReadBoolean();
            

}


}


}