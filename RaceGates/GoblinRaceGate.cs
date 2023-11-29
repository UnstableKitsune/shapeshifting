//Created By Cassius for Order of The Red Dragon
using System;

namespace Server.Items
{
public class GoblinRaceGate : Item
{
[Constructable]
public GoblinRaceGate() : base(0xF6C)
{
	Movable = false;
	Light = LightType.Circle300;
	Hue = 1005; 
	Name = "Goblin Race Gate"; 
}

public GoblinRaceGate(Serial serial) : base(serial)
{
}

public override void Serialize(GenericWriter writer)
{
base.Serialize(writer);

writer.Write((int) 0);
}

public override bool OnMoveOver( Mobile m ) 
{ 
m.SendMessage( "You are Now a part a Goblin" ); 
m.Hue = 1453;
m.Title = "The Goblin";
m.Location = new Point3D(1455, 1568, 30);
m.AddToBackpack( new GoblinShiftTalisman() );
World.Broadcast( 0x35, true, "Another goblin has joined! Watch your coins!" );
return false; //Changed this to false
}

public override void Deserialize(GenericReader reader)
{
base.Deserialize(reader);

int version = reader.ReadInt();
}
}
}
