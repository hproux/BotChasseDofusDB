


















// Generated on 02/22/2023 19:13:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class DiceRollRequestMessage : NetworkMessage
{

public const uint Id = 1047;
public override uint MessageId
{
    get { return Id; }
}

public uint dice;
        public uint faces;
        public sbyte channel;
        

public DiceRollRequestMessage()
{
}

public DiceRollRequestMessage(uint dice, uint faces, sbyte channel)
        {
            this.dice = dice;
            this.faces = faces;
            this.channel = channel;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)dice);
            writer.WriteVarInt((int)faces);
            writer.WriteSbyte(channel);
            

}

public override void Deserialize(IDataReader reader)
{

dice = reader.ReadVarUhInt();
            faces = reader.ReadVarUhInt();
            channel = reader.ReadSbyte();
            

}


}


}