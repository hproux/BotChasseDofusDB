


















// Generated on 02/22/2023 19:13:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class BasicAllianceInformations : AbstractSocialGroupInfos
{

public const short Id = 2850;
public override short TypeId
{
    get { return Id; }
}

public uint allianceId;
        public string allianceTag;
        

public BasicAllianceInformations()
{
}

public BasicAllianceInformations(uint allianceId, string allianceTag)
        {
            this.allianceId = allianceId;
            this.allianceTag = allianceTag;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)allianceId);
            writer.WriteUTF(allianceTag);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceId = reader.ReadVarUhInt();
            allianceTag = reader.ReadUTF();
            

}


}


}