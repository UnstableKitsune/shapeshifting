using System;

namespace Server.Items
{
public class KirinRaceGate : Item
{
[Constructable]
public KirinRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2501; 
	Name = "Kirin Race Gate"; 
}

public KirinRaceGate(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are now part Kirin" ); 
m.Hue = 1453;
m.Title = "The Kirin";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new KirinShiftTalisman() );
World.Broadcast( 0x35, true, "Where did that Kirin come from?!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
