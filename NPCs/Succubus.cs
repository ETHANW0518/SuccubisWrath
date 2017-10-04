using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SuccubisWrath.NPCs
{
	public class Succubus : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Median Succubus");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GiantTortoise];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 54;
			npc.damage = 100;
			npc.defense = 32;
			npc.lifeMax = 350;
            npc.lavaImmune = true;
            npc.buffImmune[24] = true;
            npc.HitSound = SoundID.NPCHit47;
            npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 150f;
			npc.knockBackResist = -2f;
			npc.aiStyle = 39;
			aiType = NPCID.GiantTortoise;
			animationType = NPCID.GiantTortoise;
		}
        public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            player.AddBuff(119,450,true);
        }
        public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 1; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SuccubusBody"), 1f);
				for (int k = 0; k < 2; k++)
				{
					Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 8), Main.rand.Next(npc.height / 2));
					Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/PrimeWings"), 1f);
				}
			}
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return Main.hardMode ? SpawnCondition.Underworld.Chance * 0.1f : 0;
        }
    }
}