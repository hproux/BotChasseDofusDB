


















// Generated on 02/22/2023 19:13:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class HumanOptionAlliance : HumanOption
{

public const short Id = 6815;
public override short TypeId
{
    get { return Id; }
}

public Types.AllianceInformations allianceInformations;
        public sbyte aggressable;
        

public HumanOptionAlliance()
{
}

public HumanOptionAlliance(Types.AllianceInformations allianceInformations, sbyte aggressable)
        {
            this.allianceInformations = allianceInformations;
            this.aggressable = aggressable;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            allianceInformations.Serialize(writer);
            writer.WriteSbyte(aggressable);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceInformations = new Types.AllianceInformations();
            allianceInformations.Deserialize(reader);
            aggressable = reader.ReadSbyte();
            

}


}


}