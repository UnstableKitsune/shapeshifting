//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class TreeEntRaceGate : Item
{
[Constructable]
public TreeEntRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 2514; 
	Name = "Tree Ent Race Gate"; 
}

public TreeEntRaceGate(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now part of the Ents" ); 
m.Hue = 1410;
m.Title = "The Ents";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new TreeEntShiftTalisman() );
World.Broadcast( 0x35, true, "Another Ent has Joined the community!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
