


















// Generated on 02/17/2023 18:45:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MoodSmileyRequestMessage : NetworkMessage
{

public const uint Id = 4206;
public override uint MessageId
{
    get { return Id; }
}

public uint smileyId;
        

public MoodSmileyRequestMessage()
{
}

public MoodSmileyRequestMessage(uint smileyId)
        {
            this.smileyId = smileyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)smileyId);
            

}

public override void Deserialize(IDataReader reader)
{

smileyId = reader.ReadVarUhShort();
            

}


}


}