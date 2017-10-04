using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuccubisWrath.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class LibinumMask : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Libinum Mask");
        }

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 15000;
			item.rare = 11;
			item.defense = 9;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("LibinumBreastplate") && legs.type == mod.ItemType("LibinumLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Faster melee speed";
			player.meleeSpeed *= 1.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LibinumCrystal", 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}