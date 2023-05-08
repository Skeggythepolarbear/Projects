using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Champions.Items.Accessories
{
	public class MartianNaniteAccessory : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Martian Nanite Accessory"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Futuristic Fashion with Fashists.");
		}

		public override void SetDefaults()
		{
            item.width = 20;
            item.height = 20;
            item.value = 10000;
            item.rare = 8;
            item.accessory = true;

		}

	public override void UpdateAccessory (Player player, bool hideVisual)
	{
		player.accCompass = true;
		player.accDepthMeter = true;
		player.accFlipper = true;
		player.accMerman = true;
		player.accWatch = true;
		player.noFallDmg = true;
		player.lavaImmune = true;
		player.chatText = "Equipped Martian Nanite Accessory... time to style on enemies (including the Guide)";
		player.killGuide = true;
		player.meleeCrit = 100;
		player.meleeSpeed = 2.0;
		player.meleeDamage += 500
		player.name = "bot";
		player.pStone = true;
		player.moveSpeed += 0.5f;
		player.accRunSpeed += 0.5f;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ItemID.MartianConduitPlating, 5);
		recipe.AddIngredient(ItemID.Nanites, 5);
		recipe.AddTile(TileID.WorkBenches);
		recipe.Register();
	}
	}
}