


















// Generated on 02/22/2023 19:13:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameRolePlayDelayedObjectUseMessage : GameRolePlayDelayedActionMessage
{

public const uint Id = 681;
public override uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        

public GameRolePlayDelayedObjectUseMessage()
{
}

public GameRolePlayDelayedObjectUseMessage(double delayedCharacterId, sbyte delayTypeId, double delayEndTime, uint objectGID)
         : base(delayedCharacterId, delayTypeId, delayEndTime)
        {
            this.objectGID = objectGID;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)objectGID);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadVarUhInt();
            

}


}


}