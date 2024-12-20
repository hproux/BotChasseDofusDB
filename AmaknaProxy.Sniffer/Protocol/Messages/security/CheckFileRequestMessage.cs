


















// Generated on 02/22/2023 19:13:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class CheckFileRequestMessage : NetworkMessage
{

public const uint Id = 8761;
public override uint MessageId
{
    get { return Id; }
}

public string filename;
        public sbyte type;
        

public CheckFileRequestMessage()
{
}

public CheckFileRequestMessage(string filename, sbyte type)
        {
            this.filename = filename;
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(filename);
            writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

filename = reader.ReadUTF();
            type = reader.ReadSbyte();
            

}


}


}