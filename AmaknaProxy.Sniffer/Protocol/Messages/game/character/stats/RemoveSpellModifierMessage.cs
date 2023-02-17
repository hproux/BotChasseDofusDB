


















// Generated on 02/17/2023 18:45:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class RemoveSpellModifierMessage : NetworkMessage
{

public const uint Id = 2668;
public override uint MessageId
{
    get { return Id; }
}

public double actorId;
        public sbyte modificationType;
        public uint spellId;
        

public RemoveSpellModifierMessage()
{
}

public RemoveSpellModifierMessage(double actorId, sbyte modificationType, uint spellId)
        {
            this.actorId = actorId;
            this.modificationType = modificationType;
            this.spellId = spellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(actorId);
            writer.WriteSbyte(modificationType);
            writer.WriteVarShort((int)spellId);
            

}

public override void Deserialize(IDataReader reader)
{

actorId = reader.ReadDouble();
            modificationType = reader.ReadSbyte();
            spellId = reader.ReadVarUhShort();
            

}


}


}