


















// Generated on 02/22/2023 19:13:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class JobCrafterDirectoryRemoveMessage : NetworkMessage
{

public const uint Id = 8883;
public override uint MessageId
{
    get { return Id; }
}

public sbyte jobId;
        public double playerId;
        

public JobCrafterDirectoryRemoveMessage()
{
}

public JobCrafterDirectoryRemoveMessage(sbyte jobId, double playerId)
        {
            this.jobId = jobId;
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            playerId = reader.ReadVarUhLong();
            

}


}


}