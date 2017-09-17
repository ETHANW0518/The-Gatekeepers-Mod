using Terraria.ID;
using Terraria.ModLoader;

namespace Gatekeeper.Items
{
	public class SwarmerHide : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Swarmer Hide");
			Tooltip.SetDefault("'The hide feels as strong as oak'");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 15;
			item.value = 5;
			item.rare = 2;
			item.maxStack = 999;
		}
	}
}
