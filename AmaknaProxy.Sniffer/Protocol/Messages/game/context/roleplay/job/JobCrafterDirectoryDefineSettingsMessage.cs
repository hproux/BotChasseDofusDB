


















// Generated on 02/22/2023 19:13:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class JobCrafterDirectoryDefineSettingsMessage : NetworkMessage
{

public const uint Id = 5981;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectorySettings settings;
        

public JobCrafterDirectoryDefineSettingsMessage()
{
}

public JobCrafterDirectoryDefineSettingsMessage(Types.JobCrafterDirectorySettings settings)
        {
            this.settings = settings;
        }
        

public override void Serialize(IDataWriter writer)
{

settings.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

settings = new Types.JobCrafterDirectorySettings();
            settings.Deserialize(reader);
            

}


}


}