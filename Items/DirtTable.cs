using Terraria.ID;
using Terraria.ModLoader;

namespace SuccubisWrath.Items
{
	public class DirtTable : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("DirtTable");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 35);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}