


















// Generated on 02/22/2023 19:13:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{

public class ExchangeObjectTransfertListWithQuantityToInvMessage : NetworkMessage
{

public const uint Id = 9696;
public override uint MessageId
{
    get { return Id; }
}

public uint[] ids;
        public uint[] qtys;
        

public ExchangeObjectTransfertListWithQuantityToInvMessage()
{
}

public ExchangeObjectTransfertListWithQuantityToInvMessage(uint[] ids, uint[] qtys)
        {
            this.ids = ids;
            this.qtys = qtys;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)qtys.Length);
            foreach (var entry in qtys)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVarUhInt();
            }
            limit = (ushort)reader.ReadUShort();
            qtys = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 qtys[i] = reader.ReadVarUhInt();
            }
            

}


}


}