using Terraria.ID;
using Terraria.ModLoader;

namespace Gatekeeper.Items
{
	public class SandyGel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sandy Gel");
			Tooltip.SetDefault("'This dusty gel glimmers in the light!'");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 14;
			item.value = 5;
			item.rare = 2;
			item.maxStack = 999;
		}
	}
}
