using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gatekeeper.NPCs
{
	public class GlobalDrops : GlobalNPC
	{
		
		public override void NPCLoot(NPC npc)  
        {
			if (npc.type == 537 && NPC.downedBoss2 && Main.rand.Next(3) == 1)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SandyGel"), 1); 1);
			}
			if (npc.type == 509 && NPC.downedBoss2 && Main.rand.Next(3) == 1)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SwarmerHide"), 1);
           		}
	   		if (npc.type == 61 && NPC.downedBoss2 && Main.rand.Next(3) == 1)
	    {
				Item.NewItem((int)npc.position.x, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VultureEye"), 1);
			}
        }
	}
}
