using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuccubisWrath.Items
{
    [AutoloadEquip(EquipType.Legs)]
    public class LibinumLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Libinum Leggings");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 11;
            item.defense = 18;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.3f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LibinumCrystal", 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}