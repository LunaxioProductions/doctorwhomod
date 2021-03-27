using Terraria.ID;
using Terraria.ModLoader;

namespace SolsFringeReborn.Items
{
	public class TrueSolsFringe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("True Sols Fringe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It hums and glows an orange-yellow light.");
		}

		public override void SetDefaults() 
		{
			item.damage = 120;
			item.melee = true;
			item.width = 24;
			item.height = 24;
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Projectile_157");
			item.shootSpeed = 4f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SolsFringe");
			recipe.AddIngredient(ItemID.SoulofFright, 25);
			recipe.AddIngredient(ItemID.SoulofMight, 25);
			recipe.AddIngredient(ItemID.SoulofSight, 25);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
