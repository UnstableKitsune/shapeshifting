using System;

namespace Server.Items
{
public class RidgebackRaceTile : Item
{
[Constructable]
public RidgebackRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 26; 
	Name = "Ridgeback Race Tile"; 
}

public RidgebackRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are now part Ridgeback" ); 
m.Hue = 1453;
m.Title = "The Ridgeback";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new RidgebackShiftOrb() );
World.Broadcast( 0x35, true, "WHAT?! why would you become a mount?" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
