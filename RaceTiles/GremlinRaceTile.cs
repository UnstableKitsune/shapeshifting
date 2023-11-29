//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class GremlinRaceTile : Item
{
[Constructable]
public GremlinRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 1001; 
	Name = "Gremlin Race Tile"; 
}

public GremlinRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now a part a Gremlin" ); 
m.Hue = 1453;
m.Title = "The Gremlin";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new GremlinShiftOrb() );
World.Broadcast( 0x35, true, "Another gremlin has joined! Watch your backpacks!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
