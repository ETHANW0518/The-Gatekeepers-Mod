using Terraria.ID;
using Terraria.ModLoader;

namespace Gatekeeper.Items
{
	public class VultureEye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vuture Eye");
			Tooltip.SetDefault("'Why do you have this?!'");
		}
		public override void SetDefaults()
		{
			item.width = 21;
			item.height = 15;
			item.value = 5;
			item.rare = 2;
			item.maxStack = 1;
		}
	}
}
