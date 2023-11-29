using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class RaceGateBag : Bag
	{
		public override bool IsArtifact { get { return false; } }
		public override string DefaultName
		{
			get { return "Race Gates Bag"; }
		}

		[Constructable]
		public RaceGateBag()
		{
            Hue = 0x0;

            DropItem( new AirElementalRaceGate() );
			DropItem( new AngelRaceGate() );
			DropItem( new DeamonRaceGate() );
			DropItem( new DrowRaceGate() );
			DropItem( new DwarvenRaceGate() );
			DropItem( new EarthElementalRaceGate() );
			DropItem( new ExampleRaceGate() );
			DropItem( new ElvenRaceGate() );
			DropItem( new FeyRaceGate() );
			DropItem( new GoblinRaceGate() );
			DropItem( new GremlinRaceGate() );
			DropItem( new HiryuRaceGate() );
			DropItem( new ImpRaceGate() );
			DropItem( new KirinRaceGate() );
			DropItem( new KitsuneRaceGate() );
			DropItem( new OrcRaceGate() );
			DropItem( new RaptorRaceGate() );
			DropItem( new RatmanRaceGate() );
			DropItem( new RidgebackRaceGate() );
			DropItem( new TreeEntRaceGate() );
			DropItem( new TrollRaceGate() );
			DropItem( new WolvenRaceGate() );
		}
		
		public RaceGateBag( Serial serial ) : base( serial )
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
