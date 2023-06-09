using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Champions.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
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
            Item.rare = 8;
            Item.defense = 10;
            Item.value = 2000;
        }
        
        public static void Effects(Player player)
        {
	        player.lavaImmune = true;
            player.accMerman = true;
            player.accWatch = 3;
            player.chatText = "Equipped Martian Nanite Helmet... time to style on enemies";
        }

        public override void UpdateEquip(Player player)
        {
            player.AddBuff(BuffID.Darkness, 2);
        }
    }
}