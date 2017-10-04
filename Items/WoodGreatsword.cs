using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuccubisWrath.Items
{
	public class WoodGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Greatsword");
		}
		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = true;
			item.width = 44;
			item.height = 44;
			item.useTime = 74;
			item.useAnimation = 74;
			item.useStyle = 1;	
			item.knockBack = 1;
			item.scale = 1.2f;
			item.value = 20;			//The value of the weapon
			item.rare = 3;				//The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;		//The sound when the weapon is using
			item.autoReuse = false;			//Whether the weapon can use automatically by pressing mousebutton
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 35);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
