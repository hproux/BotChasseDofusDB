


















// Generated on 02/17/2023 18:45:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AlignmentWarEffortDonateRequestMessage : NetworkMessage
{

public const uint Id = 742;
public override uint MessageId
{
    get { return Id; }
}

public double donation;
        

public AlignmentWarEffortDonateRequestMessage()
{
}

public AlignmentWarEffortDonateRequestMessage(double donation)
        {
            this.donation = donation;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(donation);
            

}

public override void Deserialize(IDataReader reader)
{

donation = reader.ReadVarUhLong();
            

}


}


}