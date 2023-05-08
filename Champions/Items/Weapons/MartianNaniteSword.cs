using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Champions.Items.Weapons
{
	public class MartianNaniteSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Style Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("15 Conduit PLating and 5 Nanites are required to destroy your enemies with style.");
		}

		public override void SetDefaults()
		{
			Item.damage = 250;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 80;
			Item.useTime = 10;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MartianConduitPlating, 15);
			recipe.AddIngredient(ItemID.Nanites, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}