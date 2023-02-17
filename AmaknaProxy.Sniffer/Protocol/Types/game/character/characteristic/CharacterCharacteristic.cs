


















// Generated on 02/17/2023 18:45:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class CharacterCharacteristic
{

public const short Id = 3999;
public virtual short TypeId
{
    get { return Id; }
}

public short characteristicId;
        

public CharacterCharacteristic()
{
}

public CharacterCharacteristic(short characteristicId)
        {
            this.characteristicId = characteristicId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(characteristicId);
            

}

public virtual void Deserialize(IDataReader reader)
{

characteristicId = reader.ReadShort();
            

}


}


}