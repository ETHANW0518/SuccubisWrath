using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SuccubisWrath.NPCs
{
	public class LesserSuccubus : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lesser Succubus");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GiantTortoise];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 50;
			npc.damage = 35;
			npc.defense = 12;
			npc.lifeMax = 150;
            npc.lavaImmune = true;
            npc.buffImmune[24] = true;
            npc.HitSound = SoundID.NPCHit47;
            npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 150f;
			npc.knockBackResist = 2f;
			npc.aiStyle = 39;
			aiType = NPCID.GiantTortoise;
			animationType = NPCID.GiantTortoise;
		}
        public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            player.AddBuff(119,25,true);
        }
        public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 1; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/LesserSuccubusBody"), 1f);
				for (int k = 0; k < 2; k++)
				{
					Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 8), Main.rand.Next(npc.height / 2));
					Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/LesserSuccubusWings"), 1f);
				}
			}
		}
		
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            return Main.hardMode ? SpawnCondition.Overworld.Chance * 0.1f : Main.hardMode ? SpawnCondition.Underground.Chance * 0.2f : Main.hardMode ? SpawnCondition.Cavern.Chance * 0.2f : SpawnCondition.Underworld.Chance * 0.1f;
        }
	}
}