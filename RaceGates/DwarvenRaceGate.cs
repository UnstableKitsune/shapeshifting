//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class DwarvenRaceGate : Item
{
[Constructable]
public DwarvenRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 748; 
	Name = "Dwarven Race Gate"; 
}

public DwarvenRaceGate(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now Dwarven" ); 
m.Hue = 748;
m.Title = "The Dwarf";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new DwarvenShiftTalisman() );
World.Broadcast( 0x35, true, "The Dwarves have added another to their Ranks..." );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
