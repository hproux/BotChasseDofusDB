


















// Generated on 02/22/2023 19:13:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeStartOkJobIndexMessage : NetworkMessage
{

public const uint Id = 4585;
public override uint MessageId
{
    get { return Id; }
}

public uint[] jobs;
        

public ExchangeStartOkJobIndexMessage()
{
}

public ExchangeStartOkJobIndexMessage(uint[] jobs)
        {
            this.jobs = jobs;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)jobs.Length);
            foreach (var entry in jobs)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            jobs = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 jobs[i] = reader.ReadVarUhInt();
            }
            

}


}


}