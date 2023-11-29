using System;

namespace Server.Items
{
public class RatmanRaceTile : Item
{
[Constructable]
public RatmanRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2213; 
	Name = "Ratman Race Tile"; 
}

public RatmanRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are now part of the Ratmen" ); 
m.Hue = 1453;
m.Title = "The Ratman";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new RatmanShiftOrb() );
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
