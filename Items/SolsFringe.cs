using Terraria.ID;
using Terraria.ModLoader;

namespace SolsFringeReborn.Items
{
	public class SolsFringe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Sols Fringe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It is bloody to the touch.");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 16;
			item.height = 16;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 1;
			item.knockBack = 7;
			item.shootSpeed = 8f;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BloodButcherer, 1);
			recipe.AddIngredient(ItemID.BladeofGrass, 1);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddIngredient(ItemID.Muramasa, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
