//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class WolvenRaceGate : Item
{
[Constructable]
public WolvenRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 705; 
	Name = "Wolven Race Gate"; 
}

public WolvenRaceGate(Serial serial) : base(serial)
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
m.AddToBackpack( new WolvenShiftTalisman() );
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
