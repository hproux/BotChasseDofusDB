


















// Generated on 02/22/2023 19:13:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AllianceModificationNameAndTagValidMessage : NetworkMessage
{

public const uint Id = 589;
public override uint MessageId
{
    get { return Id; }
}

public string allianceName;
        public string allianceTag;
        

public AllianceModificationNameAndTagValidMessage()
{
}

public AllianceModificationNameAndTagValidMessage(string allianceName, string allianceTag)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            

}

public override void Deserialize(IDataReader reader)
{

allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            

}


}


}