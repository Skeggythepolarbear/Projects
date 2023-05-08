using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Champions.Items.Armor
{
    [AutoloadEquip(EquipType.Leg)]
    public class MartianNaniteLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            SacrificeTotal = (1);
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 24;
            Item.rare = 8;
            Item.defense = 10;
            Item.value = 2000;
        }
        
 		public static void Effects(Player player)
		{
			player.moveSpeed += 12;
			player.waterWalk = true;
    		player.noFallDmg = true;
            player.chatText = "Equipped Martian Nanite Leggins... time to style on enemies";
		}
		
        public override void UpdateEquip(Player player)
        {
            player.AddBuff(BuffID.Darkness, 2);
        }
    }
}