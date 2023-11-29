using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ShiftTalismanBag : Bag
	{
		public override bool IsArtifact { get { return false; } }
		public override string DefaultName
		{
			get { return "Shift Talisman Bag"; }
		}

		[Constructable]
		public ShiftTalismanBag()
		{
            Hue = 0x0;

            DropItem( new AirElementalShiftTalisman() );
			DropItem( new AngelShiftTalisman() );
			DropItem( new DeamonShiftTalisman() );
			DropItem( new DrowShiftTalisman() );
			DropItem( new DwarvenShiftTalisman() );
			DropItem( new EarthElementalShiftTalisman() );
			DropItem( new ExampleShiftTalisman() );
			DropItem( new ElvenShiftTalisman() );
			DropItem( new FeyShiftTalisman() );
			DropItem( new GoblinShiftTalisman() );
			DropItem( new GremlinShiftTalisman() );
			DropItem( new HiryuShiftTalisman() );
			DropItem( new ImpShiftTalisman() );
			DropItem( new KirinShiftTalisman() );
			DropItem( new KitsuneShiftTalisman() );
			DropItem( new OrcShiftTalisman() );
			DropItem( new RaptorShiftTalisman() );
			DropItem( new RatmanShiftTalisman() );
			DropItem( new RidgebackShiftTalisman() );
			DropItem( new TreeEntShiftTalisman() );
			DropItem( new TrollShiftTalisman() );
			DropItem( new WolvenShiftTalisman() );
		}
		
		public ShiftTalismanBag( Serial serial ) : base( serial )
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
