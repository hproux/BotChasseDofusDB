


















// Generated on 02/17/2023 18:45:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class HavenBagFurnituresMessage : NetworkMessage
{

public const uint Id = 7743;
public override uint MessageId
{
    get { return Id; }
}

public Types.HavenBagFurnitureInformation[] furnituresInfos;
        

public HavenBagFurnituresMessage()
{
}

public HavenBagFurnituresMessage(Types.HavenBagFurnitureInformation[] furnituresInfos)
        {
            this.furnituresInfos = furnituresInfos;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)furnituresInfos.Length);
            foreach (var entry in furnituresInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            furnituresInfos = new Types.HavenBagFurnitureInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 furnituresInfos[i] = new Types.HavenBagFurnitureInformation();
                 furnituresInfos[i].Deserialize(reader);
            }
            

}


}


}