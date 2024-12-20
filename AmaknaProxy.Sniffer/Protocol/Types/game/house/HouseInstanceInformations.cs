


















// Generated on 02/22/2023 19:13:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{

public class HouseInstanceInformations
{

public const short Id = 5383;
public virtual short TypeId
{
    get { return Id; }
}

public bool secondHand;
        public bool isLocked;
        public bool hasOwner;
        public bool isSaleLocked;
        public bool isAdminLocked;
        public int instanceId;
        public Types.AccountTagInformation ownerTag;
        public double price;
        

public HouseInstanceInformations()
{
}

public HouseInstanceInformations(bool secondHand, bool isLocked, bool hasOwner, bool isSaleLocked, bool isAdminLocked, int instanceId, Types.AccountTagInformation ownerTag, double price)
        {
            this.secondHand = secondHand;
            this.isLocked = isLocked;
            this.hasOwner = hasOwner;
            this.isSaleLocked = isSaleLocked;
            this.isAdminLocked = isAdminLocked;
            this.instanceId = instanceId;
            this.ownerTag = ownerTag;
            this.price = price;
        }
        

public virtual void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, secondHand);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isLocked);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, hasOwner);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 3, isSaleLocked);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 4, isAdminLocked);
            writer.WriteByte(flag1);
            writer.WriteInt(instanceId);
            ownerTag.Serialize(writer);
            writer.WriteVarLong(price);
            

}

public virtual void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            secondHand = BooleanByteWrapper.GetFlag(flag1, 0);
            isLocked = BooleanByteWrapper.GetFlag(flag1, 1);
            hasOwner = BooleanByteWrapper.GetFlag(flag1, 2);
            isSaleLocked = BooleanByteWrapper.GetFlag(flag1, 3);
            isAdminLocked = BooleanByteWrapper.GetFlag(flag1, 4);
            instanceId = reader.ReadInt();
            ownerTag = new Types.AccountTagInformation();
            ownerTag.Deserialize(reader);
            price = reader.ReadVarLong();
            

}


}


}