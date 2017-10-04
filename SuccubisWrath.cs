using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.ModLoader;

namespace SuccubisWrath
{
	class SuccubisWrath : Mod
	{
		public SuccubisWrath()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
		
		public override void Load()
		{
        Item.potionDelay = 1000;

        //Color Color = new Color(200, 0, 100);
        //Sunlight
        //ModifySunLightColor(ref Color, ref Color);

        //Tile replacements
        Main.instance.LoadTiles(TileID.Stone);
        Main.tileTexture[TileID.Stone] = GetTexture("Tiles/SuccubusStone");
        Main.instance.LoadTiles(TileID.Dirt);
		Main.tileTexture[TileID.Dirt] = GetTexture("Tiles/SuccubusDirt");		
		Main.instance.LoadTiles(TileID.Mud);
		Main.tileTexture[TileID.Mud] = GetTexture("Tiles/SuccubusMud");
		Main.instance.LoadTiles(TileID.ClayBlock);
		Main.tileTexture[TileID.ClayBlock] = GetTexture("Tiles/SuccubusClay");
        Main.instance.LoadTiles(TileID.Sand);
        Main.tileTexture[TileID.Sand] = GetTexture("Tiles/SuccubusSand");
        Main.instance.LoadTiles(TileID.Ash);
        Main.tileTexture[TileID.Ash] = GetTexture("Tiles/SuccubusAsh");
        Main.instance.LoadTiles(TileID.SnowBlock);
        Main.tileTexture[TileID.SnowBlock] = GetTexture("Tiles/SuccubusSnow");
        //Wall replacements
        Main.instance.LoadWall(WallID.DirtUnsafe);
		Main.wallTexture[WallID.DirtUnsafe] = GetTexture("Walls/SuccubusDirtWall");
		Main.instance.LoadWall(WallID.Cave6Unsafe);
		Main.wallTexture[WallID.Cave6Unsafe] = GetTexture("Walls/SuccubusDirtWall");
		}
		
		public override void Unload()
		{
        Item.potionDelay = 3600;

        Main.tileSetsLoaded[TileID.Dirt] = false;
		Main.tileSetsLoaded[TileID.Mud] = false;
		Main.tileSetsLoaded[TileID.ClayBlock] = false;
        Main.tileSetsLoaded[TileID.Ash] = false;
        Main.tileSetsLoaded[TileID.SnowBlock] = false;
        Main.tileSetsLoaded[TileID.Sand] = false;
        Main.wallLoaded[WallID.DirtUnsafe] = false;
		Main.wallLoaded[WallID.Cave6Unsafe] = false;
		}
	}
}
