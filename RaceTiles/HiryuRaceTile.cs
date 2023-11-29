//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class HiryuRaceTile : Item
{
[Constructable]
public HiryuRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 100; 
	Name = "Hiryu Race Tile"; 
}

public HiryuRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now a part of Hiryu" ); 
m.Hue = 1453;
m.Title = "The Hiryu";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new HiryuShiftOrb() );
World.Broadcast( 0x35, true, "Another Hiryu of legend has joined!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
