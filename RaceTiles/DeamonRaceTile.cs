using System;

namespace Server.Items
{
public class DeamonRaceTile : Item
{
[Constructable]
public DeamonRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 1644; 
	Name = "Deamon Race Tile"; 
}

public DeamonRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now Deamonic" ); 
m.Hue = 434;
m.Title = "The Deamon";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new DeamonShiftOrb() );
World.Broadcast( 0x35, true, "Another walks the Path of the Deamon!" );
return false;
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
