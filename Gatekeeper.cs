using Terraria.ModLoader;

namespace Gatekeeper
{
	class Gatekeeper : Mod
	{
		public Gatekeeper()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
