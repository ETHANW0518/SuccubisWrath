using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace SuccubisWrath.Walls
{
	public class DirtBrickWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = mod.ItemType("DirtBrickWall");
			AddMapEntry(new Color(139, 106, 87));
		}
	}
}