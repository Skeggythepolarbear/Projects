using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Champions.Items.Weapons
{
	public class MartianNanitePistol : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mirror Shot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Try to no shoot yourself instantly...");
		}

		public override void SetDefaults() 
		{
			Item.damage = 800;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.knockBack = 0.1f;
			Item.value = 2500;
			Item.rare = 1; 
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 10f;
			Item.noMelee = true;
		}

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.AltFunctionUse == 2)
            {
                Item.damage = 30000;
                Item.useAnimation = 10000;
                Item.useAmmo = false;
            }else
            {
                Item.damage = 300;
                Item.useAnimation = 20;
                Item.useAmmo = true;
            }
            return true;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
           
			Vector2 offset = new Vector2(velocity.X * 3, velocity.Y * 3);
			position += offset;
			if (type == ProjectileID.Bullet)
            {
				type = Mod.Find<ModProjectile>("MartianNaniteProjectile").Type;
            }
			return true;

             if (player.AltFunctionUse == 2)
            {
                Projectile.NewProjectile(source, position, velocity, ProjectileID.InfernoFriendlyBlast, damage, knockback, player.WhoAmI); //idk if the "w" whoAmI needs to be capital or lowercase
                Main.Projectile[proj].friendly = true;
                return false;

            }
        }

        public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MartianConduitPlating, 30);
			recipe.AddIngredient(ItemID.Nanites, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

		public override Vector2? HoldoutOffset()
		{
			Vector2 offset = new Vector2(6, 0);
			return offset;
		}

	}
}