using System;

namespace Server.Items
{
public class TrollRaceGate : Item
{
[Constructable]
public TrollRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2579; 
	Name = "Troll Race Gate"; 
}

public TrollRaceGate(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are now part of the Trolls" ); 
m.Hue = 1453;
m.Title = "The Troll";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new TrollShiftTalisman() );
World.Broadcast( 0x35, true, "I hope its friendly!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
