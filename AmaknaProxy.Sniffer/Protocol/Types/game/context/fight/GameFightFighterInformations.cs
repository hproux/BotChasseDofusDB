


















// Generated on 02/22/2023 19:13:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class GameFightFighterInformations : GameContextActorInformations
{

public const short Id = 8667;
public override short TypeId
{
    get { return Id; }
}

public Types.GameContextBasicSpawnInformation spawnInfo;
        public sbyte wave;
        public Types.GameFightCharacteristics stats;
        public uint[] previousPositions;
        

public GameFightFighterInformations()
{
}

public GameFightFighterInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions)
         : base(contextualId, disposition, look)
        {
            this.spawnInfo = spawnInfo;
            this.wave = wave;
            this.stats = stats;
            this.previousPositions = previousPositions;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            spawnInfo.Serialize(writer);
            writer.WriteSbyte(wave);
            writer.WriteShort(stats.TypeId);
            stats.Serialize(writer);
            writer.WriteShort((short)previousPositions.Length);
            foreach (var entry in previousPositions)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spawnInfo = new Types.GameContextBasicSpawnInformation();
            spawnInfo.Deserialize(reader);
            wave = reader.ReadSbyte();
            stats = ProtocolTypeManager.GetInstance<Types.GameFightCharacteristics>(reader.ReadUShort());
            stats.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            previousPositions = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 previousPositions[i] = reader.ReadVarUhShort();
            }
            

}


}


}