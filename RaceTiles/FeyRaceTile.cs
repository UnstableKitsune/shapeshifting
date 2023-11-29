//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class FeyRaceTile : Item
{
[Constructable]
public FeyRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2637; 
	Name = "Fey Race Tile"; 
}

public FeyRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now Fey" ); 
m.Hue = 2637;
m.Title = "The Fey";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new FeyShiftOrb() );
World.Broadcast( 0x35, true, "Another feels the magic as they join the Fey..." );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
