using System;

namespace Server.Items
{
public class EarthElementalRaceTile : Item
{
[Constructable]
public EarthElementalRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2017; 
	Name = "Earth Elemental Race Tile"; 
}

public EarthElementalRaceTile(Serial serial) : base(serial)
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
m.AddToBackpack( new EarthElementalShiftOrb() );
World.Broadcast( 0x35, true, "Another bolder rolls in. Another elemental of earth has joined!" );
return false;
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
