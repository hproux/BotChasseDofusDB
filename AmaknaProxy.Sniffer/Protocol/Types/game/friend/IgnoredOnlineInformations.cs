


















// Generated on 02/22/2023 19:13:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class IgnoredOnlineInformations : IgnoredInformations
{

public const short Id = 277;
public override short TypeId
{
    get { return Id; }
}

public double playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        

public IgnoredOnlineInformations()
{
}

public IgnoredOnlineInformations(int accountId, Types.AccountTagInformation accountTag, double playerId, string playerName, sbyte breed, bool sex)
         : base(accountId, accountTag)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            

}


}


}