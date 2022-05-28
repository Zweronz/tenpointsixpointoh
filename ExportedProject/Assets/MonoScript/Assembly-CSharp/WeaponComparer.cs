using System;
using System.Collections;

public sealed class WeaponComparer : IComparer
{
	public static readonly string[] multiplayerWeaponsOrd = new string[449]
	{
		WeaponTags.ShotgunTag,
		WeaponTags.Red_StoneRent_Tag,
		WeaponTags.Assault_Machine_Gun_Tag,
		WeaponTags.Assault_Machine_GunBuy_Tag,
		WeaponTags.Assault_Machine_GunBuy_2_Tag,
		WeaponTags.Assault_Machine_GunBuy_3_Tag,
		WeaponTags.Valentine_Shotgun_Tag,
		WeaponTags.Valentine_Shotgun_2_Tag,
		WeaponTags.Valentine_Shotgun_3_Tag,
		WeaponTags.Water_Rifle_Tag,
		WeaponTags.Water_Rifle_2_Tag,
		WeaponTags.Water_Rifle_3_Tag,
		WeaponTags.AK47Tag,
		WeaponTags.m16_2_Tag,
		WeaponTags.Uzi2Tag,
		WeaponTags.UziTag,
		WeaponTags.DoubleShotgunTag,
		WeaponTags.m16Tag,
		WeaponTags.m16_3_Tag,
		WeaponTags.m16_4_Tag,
		WeaponTags.AK74Tag,
		WeaponTags.AK74_2_Tag,
		WeaponTags.AK74_3_Tag,
		WeaponTags.FAMASTag,
		WeaponTags.SandFamasTag,
		WeaponTags.NavyFamasTag,
		WeaponTags._3pl_ShotgunTag,
		WeaponTags.SteamPower_2_Tag,
		WeaponTags.SteamPower_3_Tag,
		WeaponTags._3_shotgun_2_Tag,
		WeaponTags._3_shotgun_3_Tag,
		WeaponTags.plazma_Tag,
		WeaponTags.plazma_2_Tag,
		WeaponTags.plazma_3_Tag,
		WeaponTags.PlasmaRifle_2_Tag,
		WeaponTags.PlasmaRifle_3_Tag,
		WeaponTags.Thompson_Tag,
		WeaponTags.StateDefender_2_tag,
		WeaponTags.MinigunTag,
		WeaponTags.RedMinigunTag,
		WeaponTags.minigun_3_Tag,
		WeaponTags.Minigun_4_Tag,
		WeaponTags.Minigun_5_Tag,
		WeaponTags.XM8_1_Tag,
		WeaponTags.XM8_2_Tag,
		WeaponTags.XM8_3_Tag,
		WeaponTags.Shmaiser_Tag,
		WeaponTags.HeavyShotgun_Tag,
		WeaponTags.HeavyShotgun_2_Tag,
		WeaponTags.HeavyShotgun_3_Tag,
		WeaponTags.AUGTag,
		WeaponTags.AUG_2Tag,
		WeaponTags.AUG_3tag,
		WeaponTags.Thompson_2_Tag,
		WeaponTags.AutoShotgun_Tag,
		WeaponTags.AutoShotgun_2_Tag,
		WeaponTags.AutoShotgun_3tag,
		WeaponTags.Red_StoneTag,
		WeaponTags.GoldenRed_StoneTag,
		WeaponTags.Red_Stone_3_Tag,
		WeaponTags.Red_Stone_4_Tag,
		WeaponTags.Red_Stone_5tag,
		WeaponTags.SPASTag,
		WeaponTags.GoldenSPASTag,
		WeaponTags.CrystalSPASTag,
		WeaponTags.PX_3000_Tag,
		WeaponTags.DualUzi_Tag,
		WeaponTags.DualUzi_2_Tag,
		WeaponTags.DualUzi_3_Tag,
		WeaponTags.FutureRifle_Tag,
		WeaponTags.FutureRifle_2_Tag,
		WeaponTags.PlasmaShotgun_Tag,
		WeaponTags.PlasmaShotgun_2_Tag,
		WeaponTags.RapidFireRifle_Tag,
		WeaponTags.RapidFireRifle_2_Tag,
		WeaponTags.FriendsUzi_Tag,
		WeaponTags.Range_Rifle_Tag,
		WeaponTags.Range_Rifle_2_Tag,
		WeaponTags.Range_Rifle_3_Tag,
		WeaponTags.Alien_rifle_Tag,
		WeaponTags.Alien_rifle_2_Tag,
		WeaponTags.Alien_rifle_3_Tag,
		WeaponTags.Mech_heavy_rifle_Tag,
		WeaponTags.gift_gun_Tag,
		WeaponTags.Icicle_Generator_Tag,
		WeaponTags.Icicle_Generator2_Tag,
		WeaponTags.Icicle_Generator3_Tag,
		WeaponTags.mp5_gold_gift_Tag,
		WeaponTags.Balloon_Cannon_Tag,
		WeaponTags.Balloon_Cannon_2_Tag,
		WeaponTags.Balloon_Cannon_3_Tag,
		WeaponTags.Dual_shotguns_1_Tag,
		WeaponTags.Dual_shotguns_2_Tag,
		WeaponTags.Dual_shotguns_3_Tag,
		WeaponTags.frank_sheepone_Tag,
		WeaponTags.frank_sheepone_up1_Tag,
		WeaponTags.frank_sheepone_up2_Tag,
		WeaponTags.PistolTag,
		WeaponTags.TwoBoltersRent_Tag,
		WeaponTags.RevolverTag,
		WeaponTags.Water_Pistol_Tag,
		WeaponTags.Water_Pistol_2_Tag,
		WeaponTags.Water_Pistol_3tag,
		WeaponTags.AlienGunTag,
		WeaponTags.GlockTag,
		WeaponTags.GoldenGlockTag,
		WeaponTags.CrystalGlockTag,
		WeaponTags.EagleTag,
		WeaponTags.BlackEagleTag,
		WeaponTags.eagle_3Tag,
		WeaponTags.BerettaTag,
		WeaponTags.WhiteBerettaTag,
		WeaponTags.BlackBerettaTag,
		WeaponTags.plazma_pistol_Tag,
		WeaponTags.plazma_pistol_2_Tag,
		WeaponTags.SparklyBlasterTag,
		WeaponTags.SparklyBlaster_2tag,
		WeaponTags.SparklyBlaster_3tag,
		WeaponTags.TwoRevolvers_Tag,
		WeaponTags.TwoRevolvers_2_Tag,
		WeaponTags.TwoRevolvers_3tag,
		WeaponTags.mauser_Tag,
		WeaponTags.Revolver2Tag,
		WeaponTags.Revolver5_Tag,
		WeaponTags.Revolver6_Tag,
		WeaponTags.revolver_2_2_Tag,
		WeaponTags.revolver_2_3_Tag,
		WeaponTags.flower_Tag,
		WeaponTags.flower_2_Tag,
		WeaponTags.flower_3_Tag,
		WeaponTags.TwoBolters_Tag,
		WeaponTags.TwoBolters_2_Tag,
		WeaponTags.TwoBolters_3_Tag,
		WeaponTags.plazma_pistol_3_Tag,
		WeaponTags.FreezeGun_0_Tag,
		WeaponTags.FreezeGun_0_2_Tag,
		WeaponTags.RailRevolver_1_Tag,
		WeaponTags.RailRevolverBuy_Tag,
		WeaponTags.RailRevolverBuy_2_Tag,
		WeaponTags.RailRevolverBuy_3_Tag,
		WeaponTags.DualHawks_Tag,
		WeaponTags.Photon_Pistol_Tag,
		WeaponTags.Photon_Pistol_2_Tag,
		WeaponTags.Alien_Laser_Pistol_Tag,
		WeaponTags.Alien_Laser_Pistol_2_Tag,
		WeaponTags.Alien_Laser_Pistol_3_Tag,
		WeaponTags.Pit_Bull_Tag,
		WeaponTags.Shotgun_Pistol_Tag,
		WeaponTags.Pit_Bull_2_Tag,
		WeaponTags.Pit_Bull_3_Tag,
		WeaponTags.Dater_DJ_Tag,
		WeaponTags.Dater_DJ_2_Tag,
		WeaponTags.Dater_DJ_3_Tag,
		WeaponTags.Space_blaster_Tag,
		WeaponTags.Space_blaster_UP1_Tag,
		WeaponTags.Space_blaster_UP2_Tag,
		WeaponTags.Red_twins_pistols_1_Tag,
		WeaponTags.Red_twins_pistols_2_Tag,
		WeaponTags.Red_twins_pistols_3_Tag,
		WeaponTags.NuclearRevolver_1_Tag,
		WeaponTags.NuclearRevolver_2_Tag,
		WeaponTags.NuclearRevolver_3_Tag,
		WeaponTags.Fighter_1_Tag,
		WeaponTags.Fighter_2_Tag,
		WeaponTags.TurboPistols_1_Tag,
		WeaponTags.TurboPistols_2_Tag,
		WeaponTags.TurboPistols_3_Tag,
		WeaponTags.dark_star_Tag,
		WeaponTags.dark_star_up1_Tag,
		WeaponTags.zombie_slayer_Tag,
		WeaponTags.zombie_slayer_up1_Tag,
		WeaponTags.zombie_slayer_up2_Tag,
		WeaponTags.KnifeTag,
		WeaponTags.Carrot_Sword_Tag,
		WeaponTags.Carrot_Sword_2_Tag,
		WeaponTags.Carrot_Sword_3_Tag,
		WeaponTags.MinersWeaponTag,
		WeaponTags.GoldenPickTag,
		WeaponTags.CrystalPickTag,
		WeaponTags.SteelAxeTag,
		WeaponTags.GoldenAxeTag,
		WeaponTags.CrystalAxeTag,
		WeaponTags.IronSwordTag,
		WeaponTags.GoldenSwordTag,
		WeaponTags.CrystalSwordTag,
		WeaponTags.HammerTag,
		WeaponTags.ChainsawTag,
		WeaponTags.Chainsaw2Tag,
		WeaponTags.MaceTag,
		WeaponTags.Mace2Tag,
		WeaponTags.Sword_2Tag,
		WeaponTags.Sword_22Tag,
		WeaponTags.Sword_2_3_Tag,
		WeaponTags.Sword_2_4_Tag,
		WeaponTags.Sword_2_5_Tag,
		WeaponTags.TreeTag,
		WeaponTags.Tree_2_Tag,
		WeaponTags.FireAxeTag,
		WeaponTags.ScytheTag,
		WeaponTags.Scythe_2_Tag,
		WeaponTags.scythe_3_Tag,
		WeaponTags.Hammer2Tag,
		WeaponTags.LightSwordTag,
		WeaponTags.RedLightSaberTag,
		WeaponTags.LightSword_3_Tag,
		WeaponTags.LightSword_4_Tag,
		WeaponTags.LightSword_5tag,
		WeaponTags.katana_Tag,
		WeaponTags.katana_2_Tag,
		WeaponTags.katana_3_Tag,
		WeaponTags.katana_4tag,
		WeaponTags.ShovelTag,
		WeaponTags.StormHammer_Tag,
		WeaponTags.Fire_orb_Tag,
		WeaponTags.Fire_orb_2_Tag,
		WeaponTags.Fire_orb_3_Tag,
		WeaponTags.Dater_Arms_Tag,
		WeaponTags.Tiger_gun_Tag,
		WeaponTags.Tiger_gun_2_Tag,
		WeaponTags.Tiger_gun_3_Tag,
		WeaponTags.Dater_Flowers_Tag,
		WeaponTags.Dater_Flowers_2_Tag,
		WeaponTags.Dater_Flowers_3_Tag,
		WeaponTags.Candy_Baton_Tag,
		WeaponTags.Hockey_stick_Tag,
		WeaponTags.Hockey_stick_UP1_Tag,
		WeaponTags.Hockey_stick_UP2_Tag,
		WeaponTags.DUAL_MACHETE_1_Tag,
		WeaponTags.DUAL_MACHETE_2_Tag,
		WeaponTags.DUAL_MACHETE_3_Tag,
		WeaponTags.chainsaw_sword_1_Tag,
		WeaponTags.chainsaw_sword_2_Tag,
		WeaponTags.zombie_head_Tag,
		WeaponTags.zombie_head_up1_Tag,
		WeaponTags.zombie_head_up2_Tag,
		WeaponTags.power_claw_Tag,
		WeaponTags.BASIC_FLAMETHROWER_Tag,
		WeaponTags.MachineGunTag,
		WeaponTags.Impulse_Sniper_Rifle_Tag,
		WeaponTags.Solar_Ray_Tag,
		WeaponTags.Solar_Ray_2_Tag,
		WeaponTags.Solar_Ray_3_Tag,
		WeaponTags.MagicBowTag,
		WeaponTags.BarrettTag,
		WeaponTags.SnowballGun_Tag,
		WeaponTags.SnowballGun_2_Tag,
		WeaponTags.SnowballGun_3_Tag,
		WeaponTags.FlamethrowerTag,
		WeaponTags.Flamethrower_2Tag,
		WeaponTags.Flamethrower_3_Tag,
		WeaponTags.Flamethrower_4tag,
		WeaponTags.Flamethrower_5tag,
		WeaponTags.RazerTag,
		WeaponTags.Razer_2Tag,
		WeaponTags.Razer_3_Tag,
		WeaponTags.TeslaTag,
		WeaponTags.Tesla_2Tag,
		WeaponTags.tesla_3_Tag,
		WeaponTags.FreezeGunTag,
		WeaponTags.FreezeGun_2_Tag,
		WeaponTags.FreezeGun_3tag,
		WeaponTags.LaserDiscThower_Tag,
		WeaponTags.LaserDiscThower_2_Tag,
		WeaponTags.Hand_dragon_Tag,
		WeaponTags.Hand_dragon_2_Tag,
		WeaponTags.Hand_dragon_3_Tag,
		WeaponTags.Alligator_Tag,
		WeaponTags.Alligator_2_Tag,
		WeaponTags.Alligator_3_Tag,
		WeaponTags.VACUUMIZER_Tag,
		WeaponTags.Shuriken_Thrower_Tag,
		WeaponTags.Shuriken_Thrower2_Tag,
		WeaponTags.Shuriken_Thrower3_Tag,
		WeaponTags.Snowball_Tag,
		WeaponTags.Snowball2_Tag,
		WeaponTags.Snowball3_Tag,
		WeaponTags.MysticOreEmitter_Tag,
		WeaponTags.MysticOreEmitter_UP1_Tag,
		WeaponTags.MysticOreEmitter_UP2_Tag,
		WeaponTags.PORTABLE_DEATH_MOON_Tag,
		WeaponTags.PORTABLE_DEATH_MOON_UP1_Tag,
		WeaponTags.PORTABLE_DEATH_MOON_UP2_Tag,
		WeaponTags.HarpoonGun_1_Tag,
		WeaponTags.HarpoonGun_2_Tag,
		WeaponTags.HarpoonGun_3_Tag,
		WeaponTags.NAIL_MINIGUN_1_Tag,
		WeaponTags.NAIL_MINIGUN_2_Tag,
		WeaponTags.NAIL_MINIGUN_3_Tag,
		WeaponTags.Gas_spreader_Tag,
		WeaponTags.Gas_spreader_up1_Tag,
		WeaponTags.LaserBouncer_1_Tag,
		WeaponTags.LaserBouncer_2_Tag,
		WeaponTags.magicbook_frostbeam_Tag,
		WeaponTags.magicbook_frostbeam_2_Tag,
		WeaponTags.Trapper_1_Tag,
		WeaponTags.Trapper_2_Tag,
		WeaponTags.AcidCannon_Tag,
		WeaponTags.AcidCannon_up1_Tag,
		WeaponTags.AcidCannon_up2_Tag,
		WeaponTags.Barier_Generator_Tag,
		WeaponTags.Barier_Generator_up1_Tag,
		WeaponTags.Barier_Generator_up2_Tag,
		WeaponTags.Chain_electro_cannon_Tag,
		WeaponTags.Chain_electro_cannon_up1_Tag,
		WeaponTags.HunterRifleTag,
		WeaponTags.Bow_3_Tag,
		WeaponTags.WoodenBowTag,
		WeaponTags.SteelCrossbowTag,
		WeaponTags.CrossbowTag,
		WeaponTags.CrystalCrossbowTag,
		WeaponTags.svdTag,
		WeaponTags.svd_2Tag,
		WeaponTags.svd_3_Tag,
		WeaponTags.TacticalBow_Tag,
		WeaponTags.TacticalBow_2_Tag,
		WeaponTags.TacticalBow_3_Tag,
		WeaponTags.RailgunTag,
		WeaponTags.railgun_2_Tag,
		WeaponTags.railgun_3_Tag,
		WeaponTags.Impulse_Sniper_RifleBuy_Tag,
		WeaponTags.Impulse_Sniper_RifleBuy_2_Tag,
		WeaponTags.Impulse_Sniper_RifleBuy_3_Tag,
		WeaponTags.Barrett_2Tag,
		WeaponTags.barret_3_Tag,
		WeaponTags.Barret_4tag,
		WeaponTags.ElectroBlastRifle_Tag,
		WeaponTags.ElectroBlastRifle_2_Tag,
		WeaponTags.Sunrise_Tag,
		WeaponTags.Needle_Throw_Tag,
		WeaponTags.Needle_Throw_2_Tag,
		WeaponTags.Needle_Throw_3_Tag,
		WeaponTags.Laser_Crossbow_Tag,
		WeaponTags.Laser_Crossbow2_Tag,
		WeaponTags.Laser_Crossbow3_Tag,
		WeaponTags.SPACE_RIFLE_Tag,
		WeaponTags.SPACE_RIFLE_UP1_Tag,
		WeaponTags.SPACE_RIFLE_UP2_Tag,
		WeaponTags.Dater_Bow_Tag,
		WeaponTags.Dater_Bow_2_Tag,
		WeaponTags.Dater_Bow_3_Tag,
		WeaponTags.Antihero_Rifle_1_Tag,
		WeaponTags.Antihero_Rifle_2_Tag,
		WeaponTags.Antihero_Rifle_3_Tag,
		WeaponTags.Toxic_sniper_rifle_1_Tag,
		WeaponTags.Toxic_sniper_rifle_2_Tag,
		WeaponTags.magicbook_thunder_Tag,
		WeaponTags.magicbook_thunder_2_Tag,
		WeaponTags.Laser_Bow_1_Tag,
		WeaponTags.Laser_Bow_2_Tag,
		WeaponTags.mr_squido_Tag,
		WeaponTags.mr_squido_up1_Tag,
		WeaponTags.mr_squido_up2_Tag,
		WeaponTags.Semiauto_sniper_Tag,
		WeaponTags.Semiauto_sniper_up1_Tag,
		WeaponTags.charge_rifle_Tag,
		WeaponTags.charge_rifle_UP1_Tag,
		WeaponTags.SignalPistol_Tag,
		WeaponTags.BadCodeGun_Tag,
		WeaponTags.PumpkinGunRent_Tag,
		WeaponTags.DragonGunRent_Tag,
		WeaponTags.RayMinigunRent_Tag,
		WeaponTags.Autoaim_Rocketlauncher_Tag,
		WeaponTags.Autoaim_RocketlauncherBuy_Tag,
		WeaponTags.Autoaim_RocketlauncherBuy_2_Tag,
		WeaponTags.Autoaim_RocketlauncherBuy_3_Tag,
		WeaponTags.Easter_Bazooka_Tag,
		WeaponTags.Easter_Bazooka_2_Tag,
		WeaponTags.Easter_Bazooka_3_Tag,
		WeaponTags.Solar_Power_Cannon_Tag,
		WeaponTags.Solar_Power_Cannon_2_Tag,
		WeaponTags.Solar_Power_Cannon_3tag,
		WeaponTags.GrenadeLuancherTag,
		WeaponTags.m79_2_Tag,
		WeaponTags.BazookaTag,
		WeaponTags.Bazooka_2Tag,
		WeaponTags.Bazooka_1_3_Tag,
		WeaponTags.GravigunTag,
		WeaponTags.gravity_2_Tag,
		WeaponTags.gravity_3_Tag,
		WeaponTags.GrenadeLuancher_2Tag,
		WeaponTags.m32_1_2_Tag,
		WeaponTags.grenade_launcher_3_Tag,
		WeaponTags.Bazooka_3Tag,
		WeaponTags.Bazooka_3_2_Tag,
		WeaponTags.Bazooka_3_3_Tag,
		WeaponTags.Bazooka_2_1_Tag,
		WeaponTags.buddy_Tag,
		WeaponTags.bigbuddy_2tag,
		WeaponTags.bigbuddy_3tag,
		WeaponTags.StaffTag,
		WeaponTags.Staff2Tag,
		WeaponTags.m79_3_Tag,
		WeaponTags.Staff_3_Tag,
		WeaponTags.Basscannon_Tag,
		WeaponTags.SnowballMachingun_Tag,
		WeaponTags.SnowballMachingun_2_Tag,
		WeaponTags.SnowballMachingun_3_Tag,
		WeaponTags.CherryGunTag,
		WeaponTags.Bazooka_2_3_Tag,
		WeaponTags.Bazooka_2_4tag,
		WeaponTags.PumpkinGun_1_Tag,
		WeaponTags.PumpkinGun_2_Tag,
		WeaponTags.PumpkinGun_5_Tag,
		WeaponTags.DragonGun_Tag,
		WeaponTags.DragonGun_2_Tag,
		WeaponTags.RayMinigun_Tag,
		WeaponTags.Bastion_Tag,
		WeaponTags.Devostator_Tag,
		WeaponTags.Devostator_2_Tag,
		WeaponTags.Dark_Matter_Generator_Tag,
		WeaponTags.Dark_Matter_Generator_2_Tag,
		WeaponTags.Hydra_Tag,
		WeaponTags.Hydra_2_Tag,
		WeaponTags.Tesla_Cannon_Tag,
		WeaponTags.Tesla_Cannon_2_Tag,
		WeaponTags.Tesla_Cannon_3_Tag,
		WeaponTags.Hippo_Tag,
		WeaponTags.Hippo_2_Tag,
		WeaponTags.Hippo_3_Tag,
		WeaponTags.Alien_Cannon_Tag,
		WeaponTags.Alien_Cannon_2_Tag,
		WeaponTags.Alien_Cannon_3_Tag,
		WeaponTags.Fireworks_Launcher_Tag,
		WeaponTags.Fireworks_Launcher_2_Tag,
		WeaponTags.Fireworks_Launcher_3_Tag,
		WeaponTags.Nutcracker_Tag,
		WeaponTags.Nutcracker2_Tag,
		WeaponTags.Nutcracker3_Tag,
		WeaponTags.Dynamite_Gun_1_Tag,
		WeaponTags.Dynamite_Gun_2_Tag,
		WeaponTags.Dynamite_Gun_3_Tag,
		WeaponTags.magicbook_fireball_Tag,
		WeaponTags.magicbook_fireball_2_Tag,
		WeaponTags.magicbook_fireball_3_Tag,
		WeaponTags.loud_piggy_Tag,
		WeaponTags.loud_piggy_up1_Tag,
		WeaponTags.toy_bomber_Tag,
		WeaponTags.toy_bomber_up1_Tag,
		WeaponTags.toy_bomber_up2_Tag,
		WeaponTags.spark_shark_Tag,
		WeaponTags.RocketCrossbow_Tag,
		WeaponTags.RocketCrossbow_up1_Tag,
		WeaponTags.RocketCrossbow_up2_Tag,
		WeaponTags.autoaim_bazooka_Tag,
		WeaponTags.autoaim_bazooka_up1_Tag,
		WeaponTags.Ghost_Lantern_Tag,
		WeaponTags.Ghost_Lantern_up1_Tag,
		WeaponTags.Demoman_Tag,
		WeaponTags.Demoman_up1_Tag
	};

	public int Compare(object x, object y)
	{
		string tag = ItemDb.GetByPrefabName(((Weapon)x).weaponPrefab.name.Replace("(Clone)", string.Empty)).Tag;
		string tag2 = ItemDb.GetByPrefabName(((Weapon)y).weaponPrefab.name.Replace("(Clone)", string.Empty)).Tag;
		return Array.IndexOf(multiplayerWeaponsOrd, tag2).CompareTo(Array.IndexOf(multiplayerWeaponsOrd, tag));
	}
}