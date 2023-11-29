using System;

namespace Server.Items
{
public class KitsuneRaceTile : Item
{
[Constructable]
public KitsuneRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 1161; 
	Name = "Kitsune Race Tile"; 
}

public KitsuneRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now an Kitsune" ); 
m.Hue = 1150;
m.Title = "The Kitsune";
m.AddToBackpack( new KitsuneShiftOrb() );
m.Location = new Point3D(1455, 1568, 30);
World.Broadcast( 0x35, true, "Another Kitsune has blessed us with their presence!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
