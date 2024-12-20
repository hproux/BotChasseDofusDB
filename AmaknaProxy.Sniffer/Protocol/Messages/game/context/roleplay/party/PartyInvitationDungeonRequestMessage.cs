


















// Generated on 02/22/2023 19:13:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
{

public const uint Id = 6487;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        

public PartyInvitationDungeonRequestMessage()
{
}

public PartyInvitationDungeonRequestMessage(Types.AbstractPlayerSearchInformation target, uint dungeonId)
         : base(target)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)dungeonId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadVarUhShort();
            

}


}


}