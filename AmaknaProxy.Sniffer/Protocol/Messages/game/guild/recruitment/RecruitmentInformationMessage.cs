


















// Generated on 02/22/2023 19:13:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class RecruitmentInformationMessage : NetworkMessage
{

public const uint Id = 3258;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildRecruitmentInformation recruitmentData;
        

public RecruitmentInformationMessage()
{
}

public RecruitmentInformationMessage(Types.GuildRecruitmentInformation recruitmentData)
        {
            this.recruitmentData = recruitmentData;
        }
        

public override void Serialize(IDataWriter writer)
{

recruitmentData.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

recruitmentData = new Types.GuildRecruitmentInformation();
            recruitmentData.Deserialize(reader);
            

}


}


}