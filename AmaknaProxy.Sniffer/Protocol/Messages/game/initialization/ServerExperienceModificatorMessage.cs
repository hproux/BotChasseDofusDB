


















// Generated on 02/22/2023 19:13:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ServerExperienceModificatorMessage : NetworkMessage
{

public const uint Id = 6426;
public override uint MessageId
{
    get { return Id; }
}

public uint experiencePercent;
        

public ServerExperienceModificatorMessage()
{
}

public ServerExperienceModificatorMessage(uint experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)experiencePercent);
            

}

public override void Deserialize(IDataReader reader)
{

experiencePercent = reader.ReadVarUhShort();
            

}


}


}