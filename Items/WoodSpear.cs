using System;
using SuccubisWrath.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuccubisWrath.Items
{
	public class WoodSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Spear");
		}
		public override void SetDefaults()
		{
			item.damage = 6;
			item.width = 32;
			item.height = 32;
			item.useTime = 38;
			item.useAnimation = 38;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 300;
			item.rare = 2;
			item.shootSpeed = 2f;
			
			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = false;

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<WoodSpearProjectile>();
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
