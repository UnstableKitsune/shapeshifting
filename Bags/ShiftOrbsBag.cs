using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ShiftOrbBag : Bag
	{
		public override bool IsArtifact { get { return false; } }
		public override string DefaultName
		{
			get { return "Shift Orb Bag"; }
		}

		[Constructable]
		public ShiftOrbBag()
		{
            Hue = 0x0;

            DropItem( new AirElementalShiftOrb() );
			DropItem( new AngelShiftOrb() );
			DropItem( new DeamonShiftOrb() );
			DropItem( new DrowShiftOrb() );
			DropItem( new DwarvenShiftOrb() );
			DropItem( new EarthElementalShiftOrb() );
			DropItem( new ExampleShiftOrb() );
			DropItem( new ElvenShiftOrb() );
			DropItem( new FeyShiftOrb() );
			DropItem( new GoblinShiftOrb() );
			DropItem( new GremlinShiftOrb() );
			DropItem( new HiryuShiftOrb() );
			DropItem( new ImpShiftOrb() );
			DropItem( new KirinShiftOrb() );
			DropItem( new KitsuneShiftOrb() );
			DropItem( new OrcShiftOrb() );
			DropItem( new RaptorShiftOrb() );
			DropItem( new RatmanShiftOrb() );
			DropItem( new RidgebackShiftOrb() );
			DropItem( new TreeEntShiftOrb() );
			DropItem( new TrollShiftOrb() );
			DropItem( new WolvenShiftOrb() );
		}
		
		public ShiftOrbBag( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
