using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Champions
{
    [AutoloadEquip(EquipType.Body)]
    public class MartianNaniteHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = (1);
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 24;
            Item.rare = 1;
            Item.defense = 10;
            Item.value = 2000;
        }
        
		public static void Effects(Player player)
		{
			player.meleeCrit += 20;
			player.noKnockback = true;
		}

		public static void SetBonus(Player player)
		{
			player.setBonus = "Increased defense by 40";
			player.statDefense += 40;
			player.statAttack += 100;
			player.socialShadow = true
		}

        public override void UpdateEquip(Player player)
        {
            player.AddBuff(BuffID.Darkness, 2);
        }
    }
}