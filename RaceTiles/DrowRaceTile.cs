using System;

namespace Server.Items
{
public class DrowRaceTile : Item
{
[Constructable]
public DrowRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 962; 
	Name = "Drow Race Tile"; 
}

public DrowRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now Drow" ); 
m.Hue = 2406;
m.Title = "The Drow";
m.AddToBackpack( new DrowShiftOrb() );
m.Location = new Point3D(1455, 1568, 30);
World.Broadcast( 0x35, true, "Another feels the Dark as they walk with the Drow!" );
return false;
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
