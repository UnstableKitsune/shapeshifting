using System;
using Server.Items;

namespace Server.Items
{
	public class DwarvenShiftTalisman : BaseTalisman
	{
		[Constructable]
		public DwarvenShiftTalisman() : base( 12121 )
        {
         Movable = true; 
         Hue = 558; 
         Name = "A Dwarven Shapeshift Talisman";
         LootType = LootType.Blessed; 
      } 


      public DwarvenShiftTalisman( Serial serial ) : base( serial ) 
      { 
      } 

      public override void Serialize( GenericWriter writer ) 
      { 
         base.Serialize( writer ); 

         writer.Write( (int) 0 ); 
      } 

      public override void Deserialize( GenericReader reader ) 
      { 
         base.Deserialize( reader ); 

         int version = reader.ReadInt(); 
	}


      public override void OnDoubleClick( Mobile from ) 
      { 
         if ( !from.InRange( GetWorldLocation(), 2 ) ) 
         	{ 
           	 from.SendLocalizedMessage( 500446 ); // That is too far away. 
         	} 
         else
		{
		if ( from.Mounted == true )
		{
		from.SendLocalizedMessage( 1042561 );
		}	         				
 	else
         { 
            if ( from.BodyValue == 0x190 || from.BodyValue == 0x191 ) 
            { 
               from.BodyMod = 101; 
               from.HueMod = 0x0;  

            } 
            else 
            { 
               if (from.Female == true ) 
                { 
                  from.BodyMod = 401;  
 
    
                } 
               else 
                { 
                  from.BodyMod = 400; 
                  from.HueMod = -1; 
  

              } 
	{				
              }
            } 
         } 





}
      } 
   } 
}
