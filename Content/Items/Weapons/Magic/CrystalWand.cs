﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.ID;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using oceanofstars.Content.NPCs.CollisionTests;

namespace oceanofstars.Content.Items.Weapons.Magic
{
    internal class CrystalWand : ModItem
    {
        public int timesFired = 0;
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Wand");
        }
        public override void SetDefaults()
        {
            Item.height = 64;
            Item.width = 30;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.useAnimation = 8;
            Item.useTime = 8;
            Item.consumable = false;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.DamageType = DamageClass.Magic;
            Item.damage = 10;
            Item.shootSpeed = 15;
            

            Item.shoot = ModContent.ProjectileType<PHwandproj>();
        }
        
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(source, Main.MouseWorld, velocity, ModContent.ProjectileType<CollisionTestNPC>(), damage * 2, knockback,player.whoAmI);
            
            
            return false;
            
        }
        
    }
}
