


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class MountRenameRequestMessage : NetworkMessage
{

public const uint Id = 6285;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public int mountId;
        

public MountRenameRequestMessage()
{
}

public MountRenameRequestMessage(string name, int mountId)
        {
            this.name = name;
            this.mountId = mountId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteVarInt((int)mountId);
            

}

public override void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            mountId = reader.ReadVarInt();
            

}


}


}