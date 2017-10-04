using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SuccubisWrath.NPCs
{
	public class DustLamia : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dust Lamia");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DesertLamiaLight];
		}

		public override void SetDefaults()
		{
			npc.width = 34;
			npc.height = 50;
			npc.damage = 5;
			npc.defense = 4;
			npc.lifeMax = 150;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 70f;
			npc.knockBackResist = -2f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertLamiaLight;
			animationType = NPCID.DesertLamiaLight;
		}
		
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 1; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/DustLamiaHead"), 1f);
				for (int k = 0; k < 1; k++)
				{
					Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 8), Main.rand.Next(npc.height / 2));
					Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/DustLamiaBody"), 1f);
				}
				for (int k = 0; k < 1; k++)
				{
					Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 3), Main.rand.Next(npc.height / 2));
					Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/DustLamiaTail"), 1f);
				}
			}
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.Underground.Chance * 0.1f ;
		}
	}
}
