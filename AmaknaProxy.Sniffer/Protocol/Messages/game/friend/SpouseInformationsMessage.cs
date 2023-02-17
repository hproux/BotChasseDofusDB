


















// Generated on 02/17/2023 18:45:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class SpouseInformationsMessage : NetworkMessage
{

public const uint Id = 4709;
public override uint MessageId
{
    get { return Id; }
}

public Types.FriendSpouseInformations spouse;
        

public SpouseInformationsMessage()
{
}

public SpouseInformationsMessage(Types.FriendSpouseInformations spouse)
        {
            this.spouse = spouse;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(spouse.TypeId);
            spouse.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

spouse = ProtocolTypeManager.GetInstance<Types.FriendSpouseInformations>(reader.ReadUShort());
            spouse.Deserialize(reader);
            

}


}


}