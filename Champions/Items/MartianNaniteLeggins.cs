using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Champions
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
            Item.rare = 1;
            Item.defense = 10;
            Item.value = 2000;
        }
        
 		public static void Effects(Player player)
		{
			player.moveSpeed += 12;
			player.waterWalk=true;
    		player.noFallDmg=true;
		}
		
        public override void UpdateEquip(Player player)
        {
            player.AddBuff(BuffID.Darkness, 2);
        }
    }
}