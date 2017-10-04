using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;

namespace SuccubisWrath
{
    public class SuccubisWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            tasks.RemoveAll(genpass => genpass.Name.Equals("Dirt Layer Caves"));
            tasks.RemoveAll(genpass => genpass.Name.Equals("Tunnels"));
            tasks.RemoveAll(genpass => genpass.Name.Equals("Surface Caves"));
            tasks.RemoveAll(genpass => genpass.Name.Equals("Wet Jungle"));
            tasks.RemoveAll(genpass => genpass.Name.Equals("Lakes"));
            int LibinumIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            int caveindex = tasks.FindIndex(genpass => genpass.Name.Equals("Rock Layer Caves"));
            if (LibinumIndex != -1)
            {
                tasks.Insert(LibinumIndex + 1, new PassLegacy("PurpleStuff", delegate (GenerationProgress progress)
                {
                    progress.Message = "Purple Stuff";

                    for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 7E-09); k++)
                    {
                        WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("Libinum"), false, 0f, 0f, false, true);
                    }
                }));
            }
            if (caveindex < 0)
                return;
            var pass = tasks.ElementAt(caveindex);
            tasks.Insert(caveindex, new PassLegacy("More Caves", delegate (GenerationProgress progress)
            {
                WorldGen.genRand.Next();
                pass.Apply(progress);
            }));
            tasks.Insert(caveindex, new PassLegacy("Alot of caves wow", delegate (GenerationProgress progress)
            {
                WorldGen.genRand.Next();
                WorldGen.genRand.Next();
                pass.Apply(progress);
            }));

            int ashIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Webs"));
            tasks.Insert(ashIndex + 1, new PassLegacy("Ash Pit", delegate (GenerationProgress progress)
            {
                int i = WorldGen.genRand.Next(0, Main.maxTilesX);
                WorldGen.TileRunner(i, Main.spawnTileY + 6, 96, 250, TileID.Ash, true, 0, 10f, true, true);
                WorldGen.TileRunner(i, Main.spawnTileY - 36, 57, 250, -1, true, 0, 10f, true, true);
            }));
        }
    }
}