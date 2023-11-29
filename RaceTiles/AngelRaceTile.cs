using System;

namespace Server.Items
{
public class AngelRaceTile : Item
{
[Constructable]
public AngelRaceTile() : base(6178)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2064; 
	Name = "Angel Race Tile"; 
}

public AngelRaceTile(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now an Angel" ); 
m.Hue = 1150;
m.Title = "The Angel";
m.AddToBackpack( new AngelShiftOrb() );
m.Location = new Point3D(1455, 1568, 30);
World.Broadcast( 0x35, true, "Another Angel has blessed us with their presence!" );
return false;
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
