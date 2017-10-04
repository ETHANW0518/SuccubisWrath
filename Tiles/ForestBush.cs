using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SuccubisWrath.Tiles
{
	class ForestBush : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileCut[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width - 1, 0);
			// This is so we can place from above.
			TileObjectData.newTile.AnchorValidTiles = new int[] {2};
			TileObjectData.newTile.Origin = new Point16(1, 2);
			TileObjectData.addTile(Type);
		}
	}
}
