


















// Generated on 02/22/2023 19:13:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class InviteInHavenBagMessage : NetworkMessage
{

public const uint Id = 4438;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations guestInformations;
        public bool accept;
        

public InviteInHavenBagMessage()
{
}

public InviteInHavenBagMessage(Types.CharacterMinimalInformations guestInformations, bool accept)
        {
            this.guestInformations = guestInformations;
            this.accept = accept;
        }
        

public override void Serialize(IDataWriter writer)
{

guestInformations.Serialize(writer);
            writer.WriteBoolean(accept);
            

}

public override void Deserialize(IDataReader reader)
{

guestInformations = new Types.CharacterMinimalInformations();
            guestInformations.Deserialize(reader);
            accept = reader.ReadBoolean();
            

}


}


}