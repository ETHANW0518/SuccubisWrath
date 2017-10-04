using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SuccubisWrath.Tiles
{
	public class DirtBrick : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = false;
			Main.tileMerge[Type][0] = true;
			Main.tileMerge[0][Type] = true;
			Main.tileMerge[Type][1] = true;
			Main.tileMerge[1][Type] = true;
			Main.tileMerge[Type][40] = true;
			Main.tileMerge[40][Type] = true;
			Main.tileMerge[1][40] = true;
			Main.tileMerge[40][1] = true;
			drop = mod.ItemType("DirtBrick");
			AddMapEntry(new Color(151, 107, 75));
		}
	}
}