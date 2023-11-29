using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class RaceTileBag : Bag
	{
		public override bool IsArtifact { get { return false; } }
		public override string DefaultName
		{
			get { return "Race Tiles Bag"; }
		}

		[Constructable]
		public RaceTileBag()
		{
            Hue = 0x0;

            DropItem( new AirElementalRaceTile() );
			DropItem( new AngelRaceTile() );
			DropItem( new DeamonRaceTile() );
			DropItem( new DrowRaceTile() );
			DropItem( new DwarvenRaceTile() );
			DropItem( new EarthElementalRaceTile() );
			DropItem( new ElvenRaceTile() );
			DropItem( new ExampleRaceTile() );
			DropItem( new FeyRaceTile() );
			DropItem( new GoblinRaceTile() );
			DropItem( new GremlinRaceTile() );
			DropItem( new HiryuRaceTile() );
			DropItem( new ImpRaceTile() );
			DropItem( new KirinRaceTile() );
			DropItem( new KitsuneRaceTile() );
			DropItem( new OrcRaceTile() );
			DropItem( new RaptorRaceTile() );
			DropItem( new RatmanRaceTile() );
			DropItem( new RidgebackRaceTile() );
			DropItem( new TreeEntRaceTile() );
			DropItem( new TrollRaceTile() );
			DropItem( new WolvenRaceTile() );
		}
		
		public RaceTileBag( Serial serial ) : base( serial )
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
