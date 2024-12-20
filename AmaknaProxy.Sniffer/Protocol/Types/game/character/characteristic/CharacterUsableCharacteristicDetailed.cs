


















// Generated on 02/22/2023 19:13:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class CharacterUsableCharacteristicDetailed : CharacterCharacteristicDetailed
{

public const short Id = 9660;
public override short TypeId
{
    get { return Id; }
}

public uint used;
        

public CharacterUsableCharacteristicDetailed()
{
}

public CharacterUsableCharacteristicDetailed(short characteristicId, int @base, int additional, int objectsAndMountBonus, int alignGiftBonus, int contextModif, uint used)
         : base(characteristicId, @base, additional, objectsAndMountBonus, alignGiftBonus, contextModif)
        {
            this.used = used;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)used);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            used = reader.ReadVarUhInt();
            

}


}


}