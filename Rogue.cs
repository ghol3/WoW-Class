using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TalentCalculator
{
    class Rogue : ControlClass
    {
        public string GetTitles(Titles idx) { return TitleInfo[(int)idx]; }
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
            int val = value;
            for (int i = j; i < max; i++)
                if (!form.isEmpty(i))
                {
                    p[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(@"rogue" + (val - minus));
                    val++;
                    p[i].Enabled = true;
                }
        }
        public int[] Fixed()
        {
            int[] array = new int[]
            {
                3, 6, 11, 12, 15, 20, 23, 27, 29, 31,
                35, 36, 38, 39, 40, 42, 43, 47, 50, 55, 
                63, 64, 67, 71, 73, 75, 79, 80, 82, 83, 
                84, 86,87, 91, 95, 99, 103, 109, 111, 115,
                116, 119, 123, 124, 126, 127, 128, 130, 131 
            };
            return array;
        }
        public int[] AbilityValue()
        {
            int[] array = new int[]
            {
                    3,2,5,3,2,3,1,2,5,3,
                    5,2,1,3,2,5,2,2,1,3,
                    3,3,3,1,3,5,1,3,2,5,
                    2,3,5,2,1,5,2,2,5,5,
                    5,1,5,2,2,3,1,2,2,5,
                    2,1,2,5,1,5,3,2,2,2,
                    3,2,1,3,3,3,2,2,1,2,
                    1,3,5,3,1,3,5,2,3,1,
                    2,5,1,1
                };
            return array;
        }
        public int GetIndex(Ints idx) { return AbilityIndex[(int)idx]; }

        private readonly static int[] AbilityIndex = 
        {
            0,
            27,
            55,
        };
        public string[] AbilityInfo()
        {
            string[] array = new string[]{
                "Improved Eviscerate -\nIncreases the damage done by your Eviscerate ability by \n7% (1/3)\n14% (2/3)\n20% (3/3)",
                "Remorseless Attacks -\nAfter killing an opponent that yields \nexperience or honor, gives you a \n20% (1/2)\n40% (2/2) \nincreased critical strike chance on your next \nSinister Strike, Hemorrhage, Backstab, Mutilate, \nAmbush, or Ghostly Strike.  Lasts 20 sec.",
                "Malice - \nIncreases your critical strike chance by \n1% (1/5)\n2% (2/5)\n3% (3/5)\n4% (4/5)\n5% (5/5).",
                "Ruthlessness - \nGives your melee finishing moves a \n20% (1/3)\n40% (2/3)\n60% (3/3) \nchance to add a combo point to your target.",
                "Blood Spatter - \nIncreases the damage caused by your Garrote \nand Rupture abilities by \n15% (1/2)\n30% (2/2).",
                "Puncturing Wounds - \nIncreases the critical strike chance of \nyour Backstab ability by \n10% (1/3)\n20% (2/3)\n30% (3/3)\nand the critical strike chance of your Mutilate ability by \n5%  (1/3)\n10% (2/3)\n15% (3/3).",
                "Vigor - \nIncreases your maximum Energy by 10.",
                "Improved Expose Armor - \nReduces the energy cost of your Expose Armor ability by \n5 (1/2)\n10 (2/2).",
                "Lethality - \nIncreases the critical strike damage bonus of all combo \npoint-generating abilities that do not require stealth by \n6% (1/5)\n12% (2/5)\n18% (3/5)\n24% (4/5)\n30% (5/5).",
                "Vile Poisons - \nIncreases the damage dealt by your poisons and Envenom ability by \n7% (1/3)\n14% (2/3)\n20% (3/3) \nand gives your damage over time poisons an additional \n10% (1/3)\n20% (2/3)\n30% (3/3) \nchance to resist dispel effects.",
                "Improved Poisons - \nIncreases the chance to apply Deadly Poison to your target by \n4% (1/5)\n8% (2/5)\n12% (3/5)\n16% (4/5)\n20% (5/5) \nand the frequency of applying Instant Poison to your target by \n10% (1/5)\n20% (2/5)\n30% (3/5)\n40% (4/5)\n50% (5/5).",
                "Fleet Footed - \nReduces the duration of all movement impairing effects by \n15% (1/2)\n30% (2/2) \nand increases your movement speed by \n8% (1/2)\n15% (2/2).  \nThis does not stack with other movement speed increasing effects.",
                "Cold Blood - \nWhen activated, increases the critical strike chance of \nyour next offensive ability by 100%.",
                "Improved Kidney Shot - \nWhile affected by your Kidney Shot ability, the target receives an additional \n3% (1/3)\n6% (2/3)\n9% (3/3) \ndamage from all sources.",
                "Quick Recovery - \nAll healing effects on you are increased by \n10% (1/2)\n20% (2/2).  \nIn addition, your finishing moves refund \n40% (1/2)\n80% (2/2) \nof their Energy cost when they fail to hit.",
                "Seal Fate - \nYour critical strikes from abilities that add combo points have a \n20% (1/5)\n40% (2/5)\n60% (3/5)\n80% (4/5)\n100% (5/5) \nchance to add an additional combo point.",
                "Murder - \nIncreases all damage caused by \n2% (1/2)\n4% (2/2).",
                "Deadly Brew - \nWhen you apply Instant, Wound or Mind-Numbing poison \nto a target, you have a \n50% (1/2)\n100% (2/2) \nchance to apply Crippling poison.",
                "Overkill - \nWhile stealthed, and for 20 seconds after breaking stealth, \nyou regenerate 30% additional energy.",
                "Deadened Nerves - \nReduces all damage taken by \n2% (1/3)\n4% (2/3)\n6% (3/3).",
                "Focused Attacks - \nYour melee critical strikes have a \n33% (1/3)\n66% (2/3)\n100% (3/3) \nchance to give you 2 energy.",
                "Find Weakness - \nOffensive ability damage increased by \n2% (1/3)\n4% (2/3)\n6% (3/3).",
                "Master Poisoner - \nIncreases the critical hit chance of all attacks made \nagainst any target you have poisoned by \n1% (1/3)\n2% (2/3)\n3% (3/3), \nreduces the duration of all Poison effects applied to you by \n17% (1/3)\n34% (2/3)\n50% (3/3), \nand gives Envenom a \n33% (1/3)\n66% (2/3)\n100% (3/3) \nchance not to consume Deadly Poison.",
                "Mutilate - \nInstantly attacks with both weapons for 100% weapon damage \nplus an additional 44 with each weapon. Damage is increased by \n20% against Poisoned targets. Awards 2 combo points.",
                "Turn the Tables - \nWhenever anyone in your party or raid blocks, dodges, \nor parries an attack your chance to critically hit with all \ncombo moves is increased by \n2% (1/3)\n4% (2/3)\n6% (3/3) \nfor 8 sec.",
                "Cut to the Chase - \nYour Eviscerate and Envenom abilities have a \n20% (1/5)\n40% (2/5)\n60% (3/5)\n80% (4/5)\n100% (5/5) \nchance to refresh your Slice and Dice duration to its 5 combo point maximum.",
                "Hunger For Blood - \nEnrages you, increasing all damage caused by 5%.  \nRequires a bleed effect to be active on the target.  Lasts 1 min.",
                "Improved Gouge - \nIncreases the effect duration of your \nGouge ability by \n0.5 sec (1/3) \n1 sec (2/3)\n1.5 sec (3/3).",
                "Improved Sinister Strike - \nReduces the Energy cost of your \nSinister Strike ability by \n3 (1/2) \n5 (2/2).",
                "Dual Wield Specialization - \nIncreases the damage done by your \noffhand weapon by \n10% (1/5) \n20% (2/5) \n30% (3/5) \n40% (4/5) \n50% (5/5).",
                "Improved Slice and Dice - \nIncreases the duration of your \nSlice and Dice ability by \n25% (1/2) \n50% (2/2).",
                "Deflection - \nIncreases your Parry chance by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Precision - \nIncreases your chance to hit with weapon \nand poison attacks by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Endurance - \nReduces the cooldown of your \nSprint and Evasion abilities by \n30 sec (1/2) \n60 sec (2/2) \nand increases your total Stamina by \n2% (1/2) \n4% (2/2).",
                "Riposte - \nA strike that becomes active after parrying an opponent's attack.  \nThis attack deals 150% weapon damage and slows their melee \nattack speed by 20% for 30 sec.  Awards 1 combo point.",
                "Close Quarters Combat - \nIncreases your chance to get a critical strike \nwith Daggers and Fist Weapons by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Improved Kick - \nGives your Kick ability a \n50% (1/2) \n100% (2/2) \nchance to silence the target for 2 sec.",
                "Improved Sprint - \nGives a \n50% (1/2) \n100% (2/2) \nchance to remove all Movement Impairing effects \nwhen you activate your Sprint ability.",
                "Lightning Reflexes - \nIncreases your Dodge chance by \n2% (1/3) \n4% (2/3) \n6% (3/3) \nand gives you \n4% (1/3) \n7% (2/3) \n10% (3/3) \nmelee haste.",
                "Aggression - \nIncreases the damage of your Sinister Strike, \nBackstab, and Eviscerate abilities by \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5).",
                "Mace Specialization - \nYour attacks with maces ignore up to \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5) \nof your opponent's armor.",
                "Blade Flurry - \nIncreases your attack speed by 20%.  \nIn addition, attacks strike an additional \nnearby opponent.  Lasts 15 sec.",
                "Hack and Slash - \nGives you a \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5) \nchance to get an extra attack on the same target after \nhitting your target with your Sword or Axe.",
                "Weapon Expertise - \nIncreases your expertise by \n5 (1/2) \n10 (2/2).",
                "Blade Twisting - \nIncreases the damage dealt by \nSinister Strike and Backstab by \n5% (1/2) \n10% (2/2), \nand your damaging melee attacks\n have a 10% chance to Daze the target for \n4 sec (1/2) \n8 sec (2/2).",
                "Vitality - \nIncreases your Energy regeneration rate by \n8% (1/3) \n16% (2/3) \n25% (3/3).",
                "Adrenaline Rush - \nIncreases your Energy regeneration rate by 100% for 15 sec.",
                "Nerves of Steel - \nReduces damage taken while affected by\n Stun and Fear effects by \n15% (1/2) \n30% (2/2).",
                "Throwing Specialization - \nIncreases the range of Throw and Deadly Throw by \n2 yards (1/2) \n4 yards (2/2) \nand gives your Deadly Throw a \n50% (1/2) \n100% (2/2) \nchance to interrupt the target for 3 sec.",
                "Combat Potency - \nGives your successful off-hand melee \nattacks a 20% chance to generate \n3 (1/5) \n6 (2/5) \n9 (3/5) \n12 (4/5) \n15 (5/5) \nEnergy.",
                "Unfair Advantage - \nWhenever you dodge an attack you gain\n an Unfair Advantage, striking back for \n50% (1/2) \n100% (2/2) \nof your main hand weapon's damage.  \nThis cannot occur more than once per second.",
                "Surprise Attacks - \nYour finishing moves can no longer be dodged, and the damage \ndealt by your Sinister Strike, Backstab, Shiv, \nHemorrahage and Gouge abilities is increased by 10%",
                "Savage Combat - \nIncreases your total attack power by \n2% (1/2) \n4% (2/2) \nand all physical damage caused to enemies you have poisoned is increased by \n2% (1/2) \n4% (2/2).",
                "Prey on the Weak - \nYour critical strike damage is increased by \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5) \nwhen the target has less health than you \n(as a percentage of total health).",
                "Killing Spree - \nStep through the shadows from enemy to enemy within 10 yards, \nattacking an enemy every 5 secs with both weapons until 5 assaults are made, \nand increasing all damage done by 20% for the duration.  \nCan hit the same target multiple times.  \nCannot hit invisible or stealthed targets.",
                "Relentless Strikes - \nYour finishing moves have a \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5) \nchance per combo point to restore 25 energy.",
                "Master of Deception - \nReduces the chance enemies have to \ndetect you while in Stealth mode \nActive (1/3) \nmore effective (2/3) \nmore effective (2/3).",
                "Opportunity - \nIncreases the damage dealt with your Backstab, Mutilate, \nGarrote and Ambush abilities by \n10% (1/2) \n20% (2/2).",
                "Sleight of Hand - \nReduces the chance you are critically hit by melee\n and ranged attacks by \n1% (1/2) \n2% (2/2) \nand increases the threat reduction of your Feint ability by \n10% (1/2) \n20% (2/2).",
                "Dirty Tricks - \nIncreases the range of your Blind and Sap abilities by \n2 yards (1/2) \n5 yards (2/2) \nand reduces the energy cost of your Blind and Sap abilities by \n25% (1/2) \n50% (2/2).",
                "Camouflage - \nIncreases your speed while stealthed by \n5% (1/3) \n10% (2/3) \n15% (3/3) \nand reduces the cooldown of your Stealth ability by \n2 sec (1/3) \n4 sec (2/3) \n6 sec (3/3).",
                "Elusiveness - \nReduces the cooldown of your Vanish and \nBlind abilities by \n30 sec (1/2) \n60 sec (2/2) \nand your Cloak of Shadows ability by \n15 sec (1/2) \n30 sec (2/2).",
                "Ghostly Strike - \nA strike that deals 125% weapon damage (180% if a dagger is equipped) \nand increases your chance to dodge by 15% for 7 sec.  \nAwards 1 combo point.",
                "Serrated Blades - \nCauses your attacks to ignore up to \n3% (1/3) \n6% (2/3) \n9% (3/3) \nof your target's Armor and increases the damage \ndealt by your Rupture ability by \n10% (1/3) \n20% (2/3) \n30% (3/3).",
                "Setup - \nGives you a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to add a combo point to your target after dodging \ntheir attack or fully resisting one of their spells.  \nThis cannot happen more than once per second.",
                "Initiative - \nGives you a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to add an additional combo point to your target\n when using your Ambush, Garrote, or Cheap Shot ability.",
                "Improved Ambush - \nIncreases the critical strike chance of your Ambush ability by \n25% (1/2) \n50% (2/2).",
                "Heightened Senses - \nIncreases your Stealth detection and reduces the chance \nyou are hit by spells and ranged attacks by \n2% (1/2) \n4% (2/2).",
                "Preparation - \nWhen activated, this ability immediately finishes the cooldown\n on your Evasion, Sprint, Vanish, Cold Blood and Shadowstep abilities.",
                "Dirty Deeds - \nReduces the Energy cost of your Cheap Shot and Garrote abilities by \n10 (1/2) \n20 (2/2).  \nAdditionally, your special abilities cause \n10% (1/2) \n20% (2/2) \nmore damage against targets below 35% health.",
                "Hemorrhage - \nAn instant strike that deals 110% weapon damage \n(160% if a dagger is equipped) and causes the target to hemorrhage, \nincreasing any Physical damage dealt to the target by up to 13.  \nLasts 10 charges or 15 sec.  \nAwards 1 combo point.",
                "Master of Subtlety - \nAttacks made while stealthed and for 6 seconds \nafter breaking stealth cause an additional \n4% (1/3) \n7% (2/3) \n10% (3/3) \ndamage.",
                "Deadliness - \nIncreases your attack power by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5).",
                "Enveloping Shadows - \nReduces the damage taken by area of effect attacks by \n10% (1/3) \n20% (2/3) \n30% (3/3).",
                "Premeditation - \nWhen used, adds 2 combo points to your target.  \nYou must add to or use those combo points within \n20 sec or the combo points are lost.",
                "Cheat Death - \nYou have a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance that an attack which would otherwise kill you will instead \nreduce you to 10% of your maximum health. \nIn addition, all damage taken will be reduced by up to 90% for 3 sec \n(modified by resilience).  \nThis effect cannot occur more than once per minute.",
                "Sinister Calling - \nIncreases your total Agility by \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5) \nand increases the percentage damage bonus \nof Backstab and Hemorrhage by an additional \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5).",
                "Waylay - \nYour Ambush and Backstab hits have a \n50% (1/2) \n100% (2/2) \nchance to unbalance a target, increasing the time between their melee and\n ranged attacks by 20%, and reducing movement speed by 50% for 8 sec.",
                "Honor Among Thieves - \nWhen anyone in your group critically hits with a damage \nor healing spell or ability, you have a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to gain a combo point on your current target.  \nThis effect cannot occur more than once every second.",
                "Shadowstep - \nAttempts to step through the shadows and reappear behind your \nenemy and increases movement speed by 70% for 3 sec. \nThe damage of your next ability is increased by 20% and \nthe threat caused is reduced by 50%.  Lasts 10 sec.",
                "Filthy Tricks - \nReduces the cooldown by \n5 sec (1/2) \n10 sec (2/2) \nand energy cost by \n5 (1/2) \n10(2/2) \nof your Tricks of the Trade, Distract and Shadowstep \nabilities and reduces the cooldown of Preparation by \n1.5 min (1/2) \n3 min (2/2).",
                "Slaughter from the Shadows - \nReduces the energy cost of your Backstab and Ambush abilities by\n 4 (1/5) \n8 (2/5) \n12 (3/5) \n16 (4/5) \n20 (5/5) \nand the energy cost of your Hemorrhage by \n1 (1/5) \n2 (2/5) \n3 (3/5) \n4 (4/5) \n5 (5/5), \nand increases all damage done by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Shadow Dance - \nEnter the Shadow Dance for 6 sec, allowing the use of Sap, \nGarrote, Ambush, Cheap Shot, Premeditation,\n Pickpocket and Disarm Trap regardless of being stealthed.",

            };
            return array;
        }
        private readonly static string[] TitleInfo = 
        {
            "Assassination",
            "Combat",
            "Subtlety",
        };
    }
}