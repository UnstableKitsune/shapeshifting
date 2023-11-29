//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class OrcRaceGate : Item
{
[Constructable]
public OrcRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 558; 
	Name = "Orc Race Gate"; 
}

public OrcRaceGate(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now Orcish" ); 
m.Hue = 2212;
m.Title = "The Orc";
m.AddToBackpack( new OrcShiftTalisman() );
m.Location = new Point3D(1455, 1568, 30);
World.Broadcast( 0x35, true, "The Orcs have Claimed another to their ranks!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
