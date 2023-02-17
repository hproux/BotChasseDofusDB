


















// Generated on 02/17/2023 18:45:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AreaFightModificatorUpdateMessage : NetworkMessage
{

public const uint Id = 7135;
public override uint MessageId
{
    get { return Id; }
}

public int spellPairId;
        

public AreaFightModificatorUpdateMessage()
{
}

public AreaFightModificatorUpdateMessage(int spellPairId)
        {
            this.spellPairId = spellPairId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(spellPairId);
            

}

public override void Deserialize(IDataReader reader)
{

spellPairId = reader.ReadInt();
            

}


}


}