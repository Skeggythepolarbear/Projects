using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Champions.Items.Projectile
{
	public class MartianNaniteBullet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Martian Bullet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("I wonder what its made out of");
		}

		public override void SetDefaults() 
		{
			Item.damage = 4;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.knockBack = 2;
			Item.value = 50;
			Item.rare = 1;
			Item.consumable = true;
			Item.shoot = Mod.Find<ModProjectile>("MartianNaniteProjectile").Type;
			Item.ammo = AmmoID.Bullet;
			Item.maxStack = 999;
			Item.shootSpeed = 4.5f;
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe(25);
			recipe.AddIngredient(ItemID.Nanite, 1);
            recipe.AddIngredient(ItemID.MartianConduitPlating, 1)
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}