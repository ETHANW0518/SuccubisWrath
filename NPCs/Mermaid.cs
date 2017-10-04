using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SuccubisWrath.NPCs
{
	public class Mermaid : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mermaid");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Piranha];
		}

		public override void SetDefaults()
		{
			npc.width = 44;
			npc.height = 44;
			npc.scale = 1.2f;
			npc.damage = 20;
			npc.defense = 2;
			npc.lifeMax = 200;
            npc.noGravity = true;
            npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 500f;
			npc.knockBackResist = -3f;
			npc.aiStyle = 16;
			aiType = NPCID.Piranha;
			animationType = NPCID.Piranha;
		}
		
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 1; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/MermaidHead"), 1f);
				for (int k = 0; k < 1; k++)
				{
					Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 8), Main.rand.Next(npc.height / 2));
					Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/MermaidBody"), 1f);
				}
				for (int k = 0; k < 1; k++)
				{
					Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 3), Main.rand.Next(npc.height / 2));
					Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/MermaidTail"), 1f);
				}
			}
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OceanMonster.Chance * 0.5f;
        }
    }
}
