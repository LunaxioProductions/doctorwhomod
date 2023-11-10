using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace DoctorWho
{
	public class Doctorwho : Mod
	{
	
                   public override void AddRecipes()
  {                               
  ModRecipe recipe = new ModRecipe(this);          
  recipe.AddIngredient(this, "TrueSolsFringe");    
  recipe.AddIngredient(ItemID.TrueExcalibur, 1);  
  recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
  recipe.AddTile(134);      
  recipe.SetResult(ItemID.TerraBlade);
  recipe.AddRecipe();
  		}
  	}
  }
