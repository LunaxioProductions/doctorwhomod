using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolsFringeReborn.Items
{
	public class Projectile_157 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Name Here");
		}

		public override void SetDefaults()
		{
			//projectile.arrow = false;
			//projectile.width = 32;
			//projectile.height = 32;
		        //projectile.aiStyle = 27;
			//projectile.light = 0.5f;
			//projectile.scale = 1.2f;
		        projectile.CloneDefaults(ProjectileID.NightBeam);
			//projectile.friendly = true;
			//projectile.ranged = true;
			//projectile.melee = true;
			aiType = ProjectileID.NightBeam;
		}

		// Additional hooks/methods here.
	}
}
