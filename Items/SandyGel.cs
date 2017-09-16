using Terraria.ID;
using Terraria.ModLoader;

namespace Gatekeeper.Items
{
	public class SandyGel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SandyGel");
			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
