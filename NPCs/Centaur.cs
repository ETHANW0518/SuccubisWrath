using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SuccubisWrath.NPCs
{
	public class Centaur : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Centaur");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Unicorn];
		}

		public override void SetDefaults()
		{
			npc.width = 70;
			npc.height = 70;
			npc.scale = 1f;
			npc.damage = 25;
			npc.defense = 8;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit12;
			npc.DeathSound = SoundID.NPCDeath18;
			npc.value = 400f;
			npc.knockBackResist = -1f;
			npc.aiStyle = 26;
			aiType = NPCID.Unicorn;
			animationType = NPCID.Unicorn;
		}
		
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 1; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/CentaurHead"), 1f);
				for (int k = 0; k < 1; k++)
				{
					Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 8), Main.rand.Next(npc.height / 2));
					Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/CentaurBody"), 1f);
				}
				for (int k = 0; k < 1; k++)
				{
					Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 3), Main.rand.Next(npc.height / 2));
					Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/CentaurLegs"), 1f);
				}
			}
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.05f ;
		}
	}
}
