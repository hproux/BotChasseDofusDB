


















// Generated on 02/22/2023 19:13:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class LockableChangeCodeMessage : NetworkMessage
{

public const uint Id = 5435;
public override uint MessageId
{
    get { return Id; }
}

public string code;
        

public LockableChangeCodeMessage()
{
}

public LockableChangeCodeMessage(string code)
        {
            this.code = code;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(code);
            

}

public override void Deserialize(IDataReader reader)
{

code = reader.ReadUTF();
            

}


}


}