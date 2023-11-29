using System;

namespace Server.Items
{
public class RaptorRaceTile : Item
{
[Constructable]
public RaptorRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2212; 
	Name = "Raptor Race Tile"; 
}

public RaptorRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are now part Raptor" ); 
m.Hue = 1453;
m.Title = "The Raptor";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new RaptorShiftOrb() );
World.Broadcast( 0x35, true, "WHAT?! did i just see a Raptor walk by??" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
