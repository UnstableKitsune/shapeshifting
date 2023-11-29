using System;

namespace Server.Items
{
public class ImpRaceGate : Item
{
[Constructable]
public ImpRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 1453; 
	Name = "Imp Race Gate"; 
}

public ImpRaceGate(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are now part Imp" ); 
m.Hue = 1453;
m.Title = "The Imp";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new ImpShiftTalisman() );
World.Broadcast( 0x35, true, "I wonder what this Imp could be up to!?" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
