using System;

namespace Server.Items
{
public class AirElementalRaceTile : Item
{
[Constructable]
public AirElementalRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2593; 
	Name = "Air Elemental Race Tile"; 
}

public AirElementalRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now a Air Elemental" ); 
m.Hue = 1453;
m.Title = "The Elements";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new AirElementalShiftOrb() );
World.Broadcast( 0x35, true, "Another gust blows in, Another elemental of air has joined!" );
return false;
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
