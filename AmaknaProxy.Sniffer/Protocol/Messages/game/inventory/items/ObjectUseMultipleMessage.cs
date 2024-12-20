


















// Generated on 02/22/2023 19:13:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ObjectUseMultipleMessage : ObjectUseMessage
{

public const uint Id = 4566;
public override uint MessageId
{
    get { return Id; }
}

public uint quantity;
        

public ObjectUseMultipleMessage()
{
}

public ObjectUseMultipleMessage(uint objectUID, uint quantity)
         : base(objectUID)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadVarUhInt();
            

}


}


}