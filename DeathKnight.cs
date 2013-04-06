using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TalentCalculator
{
    class DeathKnight : ControlClass
    {
        private int val = 0;
        public string GetTitles(Titles idx)
        {
            return TitleInfo[(int)idx];
        }
        public void claculateValue(PictureBox image, object sender, DrawComponents form, string value, PictureBox[] p)
        {
            if (sender == image)
            {
                string s = image.Tag.ToString();
                string[] number = s.Split(';');
                int min = int.Parse(number[3]);
                switch (form.getLeftSpent() + 1)
                {
                    case 5:
                        metoda(4, 8, p, 4, form, 1);
                        break;
                    case 10:
                        metoda(8, 12, p, 8, form, 2);
                        break;
                    case 15:
                        metoda(12, 16, p, 12, form, 3);
                        break;
                    case 20:
                        metoda(16, 20, p, 16, form, 5);
                        break;
                    case 25:
                        metoda(20, 24, p, 20, form, 5);
                        break;
                    case 30:
                        metoda(24, 28, p, 24, form, 7);
                        break;
                    case 35:
                        metoda(28, 32, p, 28, form, 8);
                        break;
                    case 40:
                        metoda(32, 36, p, 32, form, 10);
                        break;
                    case 45:
                        metoda(36, 40, p, 36, form, 11);
                        break;
                    case 50:
                        metoda(40, 44, p, 40, form, 14);
                        break;
                }
                int x = int.Parse(number[0]), y = int.Parse(number[1]);
                if (value == "left")
                {
                    if (form.getLV(x) < y)
                    {
                        form.setLV(x, form.getLV(x) + 1);
                        form.setLLabel(x, form.getLV(x) + "/" + form.GetMaximum(x));
                        form.setMax();
                        form.setLSpent();
                        return;
                    }
                }
            }
        }
        private void metoda(int j, int max, PictureBox[] p, int value, Components form, int minus)
        {
            val = value;
            for (int i = j; i < max; i++)
                if (!form.isEmpty(i))
                {
                    p[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(@"death knight" + (val - minus));
                    val++;
                    p[i].Enabled = true;
                }
        }

        public int[] Fixed()
        {
            int[] array = new int[]
            {
                3, 7, 11, 13, 17, 20, 23, 27, 31, 35,
                36, 38, 39, 40, 42, 43, 47, 48, 55, 56,
                60, 67, 71, 75, 79, 80, 82, 83, 84, 86,
                87, 91, 99, 100, 107, 116, 119, 123, 124, 
                126, 127, 128, 130, 131
            };
            return array;
        }

        public int[] AbilityValue()
        {
            int[] array = new int[]
            {
                    2,3,5,5,3,2,1,5,3,3,
                    3,3,3,3,1,3,2,3,1,2,
                    2,3,1,3,1,3,5,1,
                    3,2,5,2,5,3,5,1,3,5,
                    2,2,3,3,1,1,2,3,3,1,
                    2,3,3,1,3,1,3,5,1,
                    2,3,5,2,3,2,3,3,5,1,
                    2,3,2,1,5,2,2,3,3,1,
                    5,1,2,1,3,1,3,3,1,5,
                    1
                };
            return array;
        }

        public int GetIndex(Ints idx)
        {
            return AbilityIndex[(int)idx];
        }

        private readonly static int[] AbilityIndex = 
        {
            0,
            28,
            57,
        };
        public string[] AbilityInfo()
        {
            string[] array = new string[]{
                "Butchery - \nWhenever you kill an enemy that grants experience or honor, \nyou generate up to \n10 (1/2) \n20 (2/2) \nrunic power.  \nIn addition, you generate \n1 (1/2) \n2 (2/2) \nrunic power per 5 sec while in combat.",
                "Subversion - \nIncreases the critical strike chance of Blood Strike, Scourge Strike, \nHeart Strike and Obliterate by \n3% (1/3) \n6% (2/3) \n9% (3/3), and reduces threat generated while in Blood or \nUnholy Presence by \n8% (1/3) \n16% (2/3) \n25% (3/3).",
                "Blade Barrier - \nWhenever your Blood Runes are on cooldown, you gain \nthe Blade Barrier effect, which decreases damage taken by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5) \nfor the next 10 sec.",
                "Bladed Armor - \nIncreases your attack power by \n1 (1/5) \n2 (2/5) \n3 (3/5) \n4 (4/5) \n5 (5/5) \nfor every 180 armor value you have.",
                "Scent of Blood - \nYou have a 15% chance after dodging, parrying or taking  \ndirect damage to gain the Scent of Blood effect, causing your next \n1 (1/3) \n2 (2/3) \n3 (3/3) \nmelee hit to generate 10 runic power.",
                "Two-Handed Weapon Specialization - \nIncreases the damage you deal with \ntwo-handed melee weapons by \n2% (1/2) \n4% (2/2).",
                "Rune Tap - \nConverts 1 Blood Rune into 10% of your maximum health.",
                "Dark Conviction - \nIncreases your chance to critically hit with weapons, \nspells and abilities by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Death Rune Mastery - \nWhenever you hit with Death Strike or Obliterate there is a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance that the Frost and Unholy Runes will become Death \nRunes when they activate.  Death Runes count as a Blood, \nFrost or Unholy Rune.",
                "Improved Rune Tap - \nIncreases the health provided by Rune Tap by \n33% (1/3) \n66% (2/3) \n100% (3/3) \nand lowers its cooldown by \n10 sec (1/3) \n20 sec (2/3) \n30 sec (3/3).",
                "Spell Deflection - \nYou have a chance equal to your Parry chance of taking \n15% (1/3) \n30% (2/3) \n45% (3/3) \nless damage from a direct damage spell.",
                "Vendetta - \nHeals you for up to \n2% (1/3) \n4% (2/3) \n6% (3/3) of your maximum health whenever you kill \na target that yields experience or honor.",
                "Bloody Strikes - \nIncreases the damage of Blood Strike by \n5% (1/3) \n10% (2/3) \n15% (3/3) \nand Heart Strike by \n15% (1/3) \n30% (2/3) \n45% (3/3), \nand increases the damage of Blood Boil by 10%.",
                "Veteran of the Third War - \nIncreases your total Strength by \n2% (1/3) \n4% (2/3) \n6% (3/3), \nyour Stamina by \n1% (1/3) \n2% (2/3) \n3% (3/3), \nand your expertise by \n2 (1/3) \n4 (2/3) \n6 (3/3).",
                "Mark of Blood - \nPlace a Mark of Blood on an enemy.  Whenever the marked enemy deals damage\n to a target, that target is healed for 4% of its maximum health.  \nLasts for 20 sec or up to 20 hits.",
                "Bloody Vengeance - \nGives you a \n1% (1/3) \n2% (2/3) \n3% (3/3) \nbonus to physical damage you deal for 30 sec after dealing a critical strike\n from a weapon swing, spell, or ability.  This effect stacks up to 3 times.",
                "Abomination's Might - \nIncreases the attack power by \n5% (1/2) \n10% (2/2) \nof party and raid members within 100 yards.  \nAlso increases your total Strength by \n1% (1/2) \n2% (2/2).",
                "Bloodworms - \nYour weapon hits have a \n3% (1/3) \n6% (2/3) \n9% (3/3) chance to cause the target to spawn 2-4 Bloodworms.  \nBloodworms attack your enemies, healing you as they do damag\ne for 20 sec or until killed.",
                "Hysteria - \nInduces a friendly unit into a killing frenzy for 30 sec.  The target is Enraged, \nwhich increases their physical damage by 20%, but causes them \nto lose health equal to 1% of their maximum health every second.",
                "Improved Blood Presence - \nWhile in Frost Presence or Unholy Presence, you retain \n2% (1/2) \n4% (2/2) \nhealing from Blood Presence, and healing done to you is increased by \n5% (1/2) \n10% (2/2) \nin Blood Presence.",
                "Improved Death Strike - \nIncreases the damage of your Death Strike by \n15% (1/2) \n30% (2/2), \nincreases its critical strike chance by \n3% (1/2) \n6% (2/2) \nand increases the healing granted by \n25% (1/2) \n50% (2/2).",
                "Sudden Doom - \nYour Blood Strikes and Heart Strikes have a \n5% (1/3) \n10% (2/3) \n15% (3/3) \nchance to launch a free Death Coil at your target.",
                "Vampiric Blood - \nTemporarily grants the Death Knight 15% of maximum health\n and increases the amount of health generated through spells \nand effects by 35% for 10 sec.  After the effect expires, the health is lost.",
                "Will of the Necropolis - \nDamage that would take you below 35% health \nor taken while you are at 35% health is reduced by \n5% (1/3) \n10% (2/3) \n15% (3/3).",
                "Heart Strike - \nInstantly strike the target and his nearest ally, causing 50% weapon damage \nplus 125 on the primary target, and 25% weapon damage plus 63 on the secondary target.  \nEach target takes 10% additional damage for each of your diseases active on that target.",
                "Might of Mograine - \nIncreases the critical strike damage bonus of your Blood Boil, \nBlood Strike, Death Strike, and Heart Strike abilities by \n15% (1/3) \n30% (2/3) \n45% (3/3).",
                "Blood Gorged - \nWhen you are above 75% health, you deal \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5) \nmore damage.  In addition, your attacks ignore up to \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5) \nof your opponent's armor at all times.",
                "Dancing Rune Weapon - \nSummons a second rune weapon that fights on its own for 12 sec, \ndoing the same attacks as the Death Knight but for 50% reduced damage.",
                "Improved Icy Touch - \nYour Icy Touch does an additional \n5% (1/3) \n10% (2/3) \n15% (3/3) \ndamage and your Frost Fever reduces melee \nand ranged attack speed by an additional \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Runic Power Mastery - \nIncreases your maximum Runic Power by \n15 (1/2) \n30 (2/2).",
                "Toughness - \nIncreases your armor value from items by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5) \nand reduces the duration of all movement slowing effects by \n6% (1/5) \n12% (2/5) \n18% (3/5) \n24% (4/5) \n30% (5/5).",
                "Icy Reach - \nIncreases the range of your Icy Touch,  Chains of Ice and Howling Blast by \n5 yards (1/2) \n10 yards (2/2).",
                "Black Ice - \nIncreases your Frost and Shadow damage by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5).",
                "Nerves of Cold Steel - \nIncreases your chance to hit with one-handed melee weapons by \n1% (1/3) \n2% (2/3) \n3% (3/3) \nand increases the damage done by your offhand weapon by \n8% (1/3) \n16% (2/3) \n25% (3/3).",
                "Icy Talons - \nYou leech heat from victims of your Frost Fever, so that when \ntheir melee attack speed is reduced, yours increases by \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5) \nfor the next 20 sec.",
                "Lichborne - \nDraw upon unholy energy to become undead for 10 sec.  While undead, you are immune to Charm, Fear and Sleep effects.",
                "Annihilation - \nIncreases the critical strike chance of your melee special abilities by \n1% (1/3) \n2% (2/3) \n3% (3/3).  \nIn addition, there is a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance that your Obliterate will do its damage without consuming diseases.",
                "Killing Machine - \nYour melee attacks have a chance to make your next Icy Touch, \nHowling Blast or Frost Strike a critical strike. \nEffect occurs more often than Killing Machine \nUpgrade1 (1/5) \nUpgrade2 (2/5) \nUpgrade3 (3/5) \nUpgrade4 (4/5) \nUpgrade5 (5/5)",
                "Chill of the Grave - \nYour Chains of Ice, Howling Blast, Icy Touch and Obliterate generate \n2.5 (1/2) \n5 (2/2) \nadditional runic power.",
                "Endless Winter - \nYour strength is increased by \n2%  Mind Freeze is reduced to 10 runic power (1/2)  \n4%  Mind freeze no longer costs runic power (2/2).",
                "Frigid Dreadplate - \nReduces the chance melee attacks will hit you by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Glacier Rot - \nDiseased enemies take \n7% (1/3) \n13% (2/3) \n20% (3/3) \nmore damage from your Icy Touch, Howling Blast and Frost Strike.",
                "Deathchill - \nWhen activated, makes your next Icy Touch, Howling Blast, Frost Strike or Obliterate a critical hit if used within 30 sec.",
                "Improved Icy Talons - \nIncreases the melee haste of all party and raid members within 100 yds by 20% and your haste by an additional 5%.",
                "Merciless Combat - \nYour Icy Touch, Howling Blast, Obliterate and Frost Strike do an additional \n6% (1/2) \n12% (2/2) \ndamage when striking targets with less than 35% health.",
                "Rime - \nIncreases the critical strike chance of your Icy Touch and Obliterate by \n5% (1/3) \n10% (2/3) \n15% (3/3) \nand casting Obliterate has a \n5% (1/3) \n10% (2/3) \n15% (3/3) \nchance to reset the cooldown on Howling Blast and cause \nyour next Howling Blast to consume no runes.",
                "Chilblains - \nVictims of your Frost Fever disease are Chilled, reducing movement speed by \n15% (1/3) \n30% (2/3) \n50% (3/3) \nfor 10 sec.",
                "Hungering Cold - \nPurges the earth around the Death Knight of all heat.  \nEnemies within 10 yards are trapped in ice, preventing them from performing \nany action for 10 sec and infecting them with Frost Fever.  \nEnemies are considered Frozen, but any damage other than diseases will break the ice.",
                "Improved Frost Presence - \nWhile in Blood Presence or Unholy Presence, you retain \n4% (1/2) \n8% (2/2) \nstamina from Frost Presence, \nand damage done to you is decreased by an additional \n1% (1/2) \n2% (2/2) \nin Frost Presence.",
                "Threat of Thassarian - \nWhen dual-wielding, your Death Strikes, Obliterates, Plague Strikes, \nRune Strikes, Blood Strikes and Frost Strikes have a \n30% (1/3) \n60% (2/3) \n100% (3/3) \nchance to also deal damage with your offhand weapon.",
                "Blood of the North - \nIncreases Blood Strike and Frost Strike damage by \n3% (1/3) \n6% (2/3) \n10% (3/3).  \nIn addition, whenever you hit with Blood Strike or Pestilence there is a \n30% (1/3) \n60% (2/3) \n100% (3/3) \nchance that the Blood Rune will become a Death Rune when it activates.  \nDeath Runes count as a Blood, Frost or Unholy Rune.",
                "Unbreakable Armor - \nReinforces your armor with a thick coat of ice, increasing your armor \nby 25% and increasing your Strength by 20% for 20 sec.",
                "Acclimation - \nWhen you are hit by a spell, you have a \n10% (1/3) \n20% (2/3) \n30% (3/3) \nchance to boost your resistance to that type of magic for 18 sec.  Stacks up to 3 times.",
                "Frost Strike - \nInstantly strike the enemy, causing 55% weapon damage plus 48 as Frost damage.",
                "Guile of Gorefiend - \nIncreases the critical strike damage bonus of your Blood Strike, \nFrost Strike, Howling Blast and Obliterate abilities by \n15% (1/3) \n30% (2/3) \n45% (3/3), \nand increases the duration of your Icebound Fortitude by \n2 secs (1/3) \n4 secs (2/3) \n6 secs (3/3).",
                "Tundra Stalker - \nYour spells and abilities deal \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5) \nmore damage to targets infected with Frost Fever.  \nAlso increases your expertise by \n1 (1/5) \n2 (2/5) \n3 (3/5) \n4 (4/5) \n5 (5/5).",
                "Howling Blast - \nBlast the target with a frigid wind dealing 198 to 214 Frost damage to all enemies within 10 yards.",
                "Vicious Strikes - \nIncreases the critical strike chance by \n3% (1/2) \n6% (2/2) \nand critical strike damage bonus by \n15% (1/2) \n30% (2/2) \nof your Plague Strike and Scourge Strike.",
                "Virulence - \nIncreases your chance to hit with your spells by \n1% (1/3) \n2% (2/3) \n3% (3/3) \nand reduces the chance that your damage over time diseases can be cured by \n10% (1/3) \n20% (2/3) \n30% (3/3).",
                "Anticipation - \nIncreases your Dodge chance by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Epidemic - \nIncreases the duration of Blood Plague and Frost Fever by \n3 sec (1/2) \n6 sec (2/2).",
                "Morbidity - \nIncreases the damage and healing of Death Coil by \n5% (1/3) \n10% (2/3) \n15% (3/3) \nand reduces the cooldown on Death and Decay by \n5 sec (1/3) \n10 sec (2/3) \n15 sec (3/3).",
                "Unholy Command - \nReduces the cooldown of your Death Grip ability by \n5 sec (1/2) \n10 sec (2/2).",
                "Ravenous Dead - \nIncreases your total Strength by \n1% (1/3) \n2% (2/3) \n3% (3/3) \nand the contribution your Ghouls get from your Strength and Stamina by \n20% (1/3) \n40% (2/3) \n60% (3/3).",
                "Outbreak - \nIncreases the damage of Plague Strike by \n10% (1/3) \n20% (2/3) \n30% (3/3) \nand Scourge Strike by \n7% (1/3) \n13% (2/3) \n20% (3/3).",
                "Necrosis - \nYour auto attacks deal an additional \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5) \nShadow damage.",
                "Corpse Explosion - \nCause a corpse to explode for 166 Shadow damage to all enemies within 10 yards.  \nWill use a nearby corpse if the target is not a corpse.  \nDoes not affect mechanical or elemental corpses.",
                "On a Pale Horse - \nYou become as hard to stop as death itself.  \nThe duration of all Stun and Fear effects used against you is reduced by \n10% (1/2) \n20% (2/2), \nand your mounted speed is increased by \n10% (1/2) \n20% (2/2).  \nThis does not stack with other movement speed increasing effects.",
                "Blood-Caked Blade - \nYour auto attacks have a \n10% (1/3) \n20% (2/3) \n30% (3/3) \nchance to cause a Blood-Caked Strike, which hits for 25% \nweapon damage plus 12.5% for each of your diseases on the target.",
                "Night of the Dead - \nReduces the cooldown on Raise Dead by \n45 sec (1/2) \n90 sec (2/2) \nand the cooldown on Army of the Dead by \n2 min (1/2) \n4 min (2/2).  \nAlso reduces the damage your pet takes from creature \narea of effect attacks by \n45% (1/2) \n90% (2/2).",
                "Unholy Blight - \nCauses the victims of your Death Coil to be surrounded by a vile swarm of unholy insects, taking 10%\n of the damage done by the Death Coil over 10 sec, and preventing any diseases on the victim from being dispelled.",
                "Impurity - \nThe attack power bonus of your spells is increased by \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5).",
                "Dirge - \nYour Death Strike, Plague Strike and Scourge Strike generate \n2.5 (1/2) \n5 (2/2) additional runic power.",
                "Desecration - \nYour Plague Strikes and Scourge Strikes cause the Desecrated Ground effect.  \nTargets in the area are slowed by \n25% (1/2) \n50% (2/2) \nby the grasping arms of the dead while standing on the unholy ground.  \nLasts 20 sec.",
                "Magic Suppression - \nYou take \n2% (1/3) \n4% (2/3) \n6% (3/3) \nless damage from all magic.  \nIn addition, your Anti-Magic Shell absorbs an additional \n8% (1/3) \n16% (2/3) \n25% (3/3) \nof spell damage.",
                "Reaping - \nWhenever you hit with Blood Strike or Pestilence there is a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance that the Blood Rune becomes a Death Rune when it activates.  \nDeath Runes count as a Blood, Frost or Unholy Rune.",
                "Master of Ghouls - \nReduces the cooldown on Raise Dead by 60 sec, and the Ghoul summoned by \nyour Raise Dead spell is considered a pet under your control.  \nUnlike normal Death Knight Ghouls, your pet does not have a limited duration.",
                "Desolation - \nYour Blood Strikes cause you to deal \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5) \nadditional damage with all attacks for the next 20 sec.",
                "Anti-Magic Zone - \nPlaces a large, stationary Anti-Magic Zone that reduces spell damage done to party or raid \nmembers inside it by 75%.  The Anti-Magic Zone lasts for 10 sec or until it absorbs 10020 spell damage.",
                "Improved Unholy Presence - \nWhile in Blood Presence or Frost Presence, you retain \n8% (1/2) \n15% (2/2) \nincreased movement speed from Unholy Presence, and your \nrunes finish their cooldowns \n5% (1/2) \n10% (2/2) \nfaster in Unholy Presence.",
                "Ghoul Frenzy - \nGrants your pet 25% haste for 30 sec and  heals it for 60% of its health over the duration.",
                "Crypt Fever - \nYour diseases also cause Crypt Fever, which increases \ndisease damage taken by the target by \n10% (1/3) \n20% (2/3) \n30% (3/3).",
                "Bone Shield - \nThe Death Knight is surrounded by 3 whirling bones.  \nWhile at least 1 bone remains, she takes 20% less damage from all sources and deals 2% more damage \nwith all attacks, spells and abilities. \n Each damaging attack that lands consumes 1 bone.  Lasts 5 min.",
                "Wandering Plague - \nWhen your diseases damage an enemy, there is a chance equal \nto your melee critical strike chance that they will cause \n33% (1/3) \n66% (2/3) \n100% (3/3) \nadditional damage to the target and all enemies within 8 yards.  \nIgnores any target under the effect of a spell that is cancelled by taking damage.",
                "Ebon Plaguebringer - \nYour Crypt Fever morphs into Ebon Plague, which increases \nmagic damage taken by \n4% (1/3) \n9% (2/3) \n13% (3/3) \nin addition to increasing disease damage taken.  \nImproves your critical strike chance with weapons and spells by \n1% (1/3) \n2% (2/3) \n3% (3/3) \nat all times.",
                "Scourge Strike - \nAn unholy strike that deals 70% of weapon damage as Physical damage plus 238.  \nIn addition, for each of your diseases on your target, you deal an additional 12% of \nthe Physical damage done as Shadow damage.",
                "Rage of Rivendare - \nYour spells and abilities deal \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5) \nmore damage to targets infected with Blood Plague.  \nAlso increases your expertise by \n1 (1/5) \n2 (2/5) \n3 (3/5) \n4 (4/5) \n5 (5/5).",
                "Summon Gargoyle - \nA Gargoyle flies into the area and bombards the target with Nature damage \nmodified by the Death Knight's attack power.  Persists for 30 sec.",

            };
            return array;
        }
        private readonly static string[] TitleInfo = 
        {
            "Blood",
            "Frost",
            "Unholy",
        };
    }
}