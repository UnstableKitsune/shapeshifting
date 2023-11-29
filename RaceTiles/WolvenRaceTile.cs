//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class WolvenRaceTile : Item
{
[Constructable]
public WolvenRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 705; 
	Name = "Wolven Race Tile"; 
}

public WolvenRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now Wolven" ); 
m.Hue = 1453;
m.Title = "The Wolven";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new WolvenShiftOrb() );
World.Broadcast( 0x35, true, "Another Howls at the moon as the walk with the Pack of the Wolven!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
