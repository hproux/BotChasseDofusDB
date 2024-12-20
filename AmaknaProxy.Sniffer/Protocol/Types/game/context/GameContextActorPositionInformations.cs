


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GameContextActorPositionInformations
{

public const short Id = 4353;
public virtual short TypeId
{
    get { return Id; }
}

public double contextualId;
        public Types.EntityDispositionInformations disposition;
        

public GameContextActorPositionInformations()
{
}

public GameContextActorPositionInformations(double contextualId, Types.EntityDispositionInformations disposition)
        {
            this.contextualId = contextualId;
            this.disposition = disposition;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(contextualId);
            writer.WriteShort(disposition.TypeId);
            disposition.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

contextualId = reader.ReadDouble();
            disposition = ProtocolTypeManager.GetInstance<Types.EntityDispositionInformations>(reader.ReadUShort());
            disposition.Deserialize(reader);
            

}


}


}