


















// Generated on 02/22/2023 19:13:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class SequenceStartMessage : NetworkMessage
{

public const uint Id = 4935;
public override uint MessageId
{
    get { return Id; }
}

public sbyte sequenceType;
        public double authorId;
        

public SequenceStartMessage()
{
}

public SequenceStartMessage(sbyte sequenceType, double authorId)
        {
            this.sequenceType = sequenceType;
            this.authorId = authorId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(sequenceType);
            writer.WriteDouble(authorId);
            

}

public override void Deserialize(IDataReader reader)
{

sequenceType = reader.ReadSbyte();
            authorId = reader.ReadDouble();
            

}


}


}