


















// Generated on 02/22/2023 19:13:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class GameFightNewRoundMessage : NetworkMessage
{

public const uint Id = 1995;
public override uint MessageId
{
    get { return Id; }
}

public uint roundNumber;
        

public GameFightNewRoundMessage()
{
}

public GameFightNewRoundMessage(uint roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)roundNumber);
            

}

public override void Deserialize(IDataReader reader)
{

roundNumber = reader.ReadVarUhInt();
            

}


}


}