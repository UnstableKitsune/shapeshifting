using System;

namespace Server.Items
{
public class ExampleRaceTile : Item
{
[Constructable]
public ExampleRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 0; 
	Name = "Example Race Tile"; 
}

public ExampleRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "Example Message" ); 
m.Hue = 1453;
m.Title = "Example Title";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new ExampleShiftTalisman() );
World.Broadcast( 0x35, true, "Example Message" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
