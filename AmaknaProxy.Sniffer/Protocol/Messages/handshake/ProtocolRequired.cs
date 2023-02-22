


















// Generated on 02/22/2023 19:13:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ProtocolRequired : NetworkMessage
{

public const uint Id = 4970;
public override uint MessageId
{
    get { return Id; }
}

public string version;
        

public ProtocolRequired()
{
}

public ProtocolRequired(string version)
        {
            this.version = version;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(version);
            

}

public override void Deserialize(IDataReader reader)
{

version = reader.ReadUTF();
            

}


}


}