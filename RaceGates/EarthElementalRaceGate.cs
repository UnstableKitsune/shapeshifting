//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class EarthElementalRaceGate : Item
{
[Constructable]
public EarthElementalRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2017; 
	Name = "Earth Elemental Race Gate"; 
}

public EarthElementalRaceGate(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now a Earth Elemental" ); 
m.Hue = 1453;
m.Title = "The Elements";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new EarthElementalShiftTalisman() );
World.Broadcast( 0x35, true, "Another bolder rolls in. Another elemental of earth has joined!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
