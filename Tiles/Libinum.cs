using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SuccubisWrath.Tiles
{
	public class Libinum : ModTile
	{
		public override void SetDefaults()
		{
            mineResist = 4f;
            minPick = 110;
            Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = mod.ItemType("LibinumCrystal");
			AddMapEntry(new Color(224, 97, 157));
		}

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0f;
            b = 0.25f;
        }
    }
}