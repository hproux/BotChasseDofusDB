


















// Generated on 02/22/2023 19:13:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class AddListenerOnSynchronizedStorageMessage : NetworkMessage
{

public const uint Id = 4633;
public override uint MessageId
{
    get { return Id; }
}

public string player;
        

public AddListenerOnSynchronizedStorageMessage()
{
}

public AddListenerOnSynchronizedStorageMessage(string player)
        {
            this.player = player;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(player);
            

}

public override void Deserialize(IDataReader reader)
{

player = reader.ReadUTF();
            

}


}


}