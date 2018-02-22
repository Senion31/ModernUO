using System;
using Server;

namespace Server.Items
{
	public class NetherBoltScroll : SpellScroll
	{
		[Constructible]
		public NetherBoltScroll()
			: this( 1 )
		{
		}

		[Constructible]
		public NetherBoltScroll( int amount )
			: base( 677, 0x2D9E, amount )
		{
		}

		public NetherBoltScroll( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
}