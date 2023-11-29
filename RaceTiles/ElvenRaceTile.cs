using System;

namespace Server.Items
{
public class ElvenRaceTile : Item
{
[Constructable]
public ElvenRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 1169; 
	Name = "Elven Race Tile"; 
}

public ElvenRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now Elven" ); 
m.Hue = 1410;
m.Title = "The Elf";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new ElvenShiftOrb() );
World.Broadcast( 0x35, true, "Another Elf has Joined the community!" );
return false;
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
