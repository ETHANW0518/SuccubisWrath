using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuccubisWrath.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class LibinumBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Libinum Breastplate");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 20000;
			item.rare = 11;
			item.defense = 42;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LibinumCrystal", 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}