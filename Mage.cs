using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TalentCalculator
{
    class Mage : ControlClass
    {
        public string GetTitles(Titles idx)
        {
            return TitleInfo[(int)idx];
        }
        public void claculateValue(PictureBox image, object sender, DrawComponents form, string value, PictureBox[] p)
        { }

        public int[] Fixed()
        {
            int[] array = new int[]
            {
                3,7,18,23,27,28,31,32,35,36,39,40,42,43,
                47,51,58,63,65,67,71,73,75,79,80,82,83,84,86,87,
                91,99,103,104,109,111,115,116,119,123,124,126,127,
                128,130,131,
            };
            return array;
        }

        public int[] AbilityValue()
        {
            int[] array = new int[]
            {
                    2,3,5,3,2,5,2,3,3,1,2,
                    2,3,3,2,1,5,3,3,2,3,1,
                    3,2,5,1,5,3,2,1,
                    2,3,5,5,2,3,2,3,1,2,3,
                    2,3,3,3,1,2,5,3,1,2,2,
                    3,2,1,3,5,1,
                    3,5,3,3,2,3,3,3,1,3,2,
                    3,3,1,3,3,2,3,2,1,5,2,
                    2,3,1,3,5,1,
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
            30,
            58,
        };
        public string[] AbilityInfo()
        {
            string[] array = new string[]{
                "Arcane Subtlety - \nReduces the chance your helpful spells and damage \nover time effects will be dispelled by \n15% (1/2) \n30% (2/2) \nand reduces the threat caused by your Arcane spells by \n20% (1/2) \n40% (2/2).",
                "Arcane Focus - \nIncreases your chance to hit and reduces \nthe mana cost of your Arcane spells by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Arcane Stability - \nReduces the pushback suffered from damaging attacks \nwhile casting Arcane Missiles and Arcane Blast by \n20% (1/5) \n40% (2/5) \n60% (3/5) \n80% (4/5) \n100% (5/5).",
                "Arcane Fortitude - \nIncreases your armor by an amount equal to \n50% (1/3) \n100% (2/3) \n150% (3/3) \nof your Intellect.",
                "Magic Absorption - \nIncreases all resistances by \n0.5 (1/2) \n1 (2/2) \nper level and causes all spells you fully resist to restore \n1% (1/2) \n2% (2/2) \nof your total mana.  \n1 sec cooldown.",
                "Arcane Concentration - \nGives you a \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5) \nchance of entering a Clearcasting state after any \ndamage spell hits a target.  The Clearcasting state reduces \nthe mana cost of your next damage spell by 100%.",
                "Magic Attunement - \nIncreases the range of your Arcane spells by \n3 yards (1/2) \n6 yards (2/2) \nand the effect of your Amplify Magic and Dampen Magic spells by 25%.",
                "Spell Impact - \nIncreases the damage of your Arcane Explosion, Arcane Blast, Blast Wave, Fire Blast, \nScorch, Fireball, Ice Lance and Cone of Cold spells by an additional \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Student of the Mind - \nIncreases your total Spirit by \n4% (1/3) \n7% (2/3) \n10% (3/3).",
                "Focus Magic - \nIncreases the target's chance to critically hit with spells by 3%.  \nWhen the target critically hits the caster's chance to critically hit with \nspells is increased by 3% for 10 sec.  \nCannot be cast on self.",
                "Arcane Shielding - \nDecreases the mana lost per point of damage \ntaken when Mana Shield is active by \n17% (1/2) \n33% (2/2) \nand increases the resistances granted by Mage Armor by \n25% (1/2) \n50% (2/2).",
                "Improved Counterspell - \nYour Counterspell also silences the target for \n2 sec (1/2) \n4 sec (2/2).",
                "Arcane Meditation - \nAllows \n17% (1/3) \n33% (2/3) \n50% (3/3) \nof your mana regeneration to continue while casting.",
                "Torment the Weak - \nYour Frostbolt, Fireball, Frostfire Bolt, Pyroblast, Arcane Missiles, \nArcane Blast, and Arcane Barrage abilities deal \n4% (1/3) \n8% (2/3) \n12% (3/3) \nmore damage to snared or slowed targets.",
                "Improved Blink - \nReduces the mana cost of Blink by \n25% (1/2) \n50% (2/2) \nand for 4 sec after casting your chance to be hit by all attacks and spells is reduced by \n15% (1/2) \n30% (2/2).",
                "Presence of Mind - \nWhen activated, your next Mage spell with a casting \ntime less than 10 sec becomes an instant cast spell.",
                "Arcane Mind - \nIncreases your total Intellect by \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5).",
                "Prismatic Cloak - \nReduces all damage taken by \n2% (1/3) \n4% (2/3) \n6% (3/3) \nand reduces the fade time of your Invisibility spell by \n1 sec (1/3) \n2 sec (2/3) \n3 sec (3/3).",
                "Arcane Instability - \nIncreases the damage done by your spells \nand your critical strike chance by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Arcane Potency - \nIncreases the critical strike chance of your next damaging spell by \n15% (1/2) \n30% (2/2) \nafter gaining Clearcasting or Presence of Mind.",
                "Arcane Empowerment - \nIncreases the damage of your Arcane Missiles \nspell by an amount equal to \n15% (1/3) \n30% (2/3) \n45% (3/3) \nof your spell power and the damage of your Arcane Blast by \n3% (1/3) \n6% (2/3) \n9% (3/3) \nof your spell power.  \nIn addition, increases the damage of all party and raid \nmembers within 100 yds by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Arcane Power - \nWhen activated, your spells deal 20% more damage while \ncosting 20% more mana to cast.  \nThis effect lasts 15 sec.",
                "Incanter's Absorption - \nWhen your Mana Shield, Frost Ward, Fire Ward, or Ice Barrier absorbs \ndamage your spell damage is increased by \n5% (1/3) \n10% (2/3) \n15% (3/3) \nof the amount absorbed for 10 sec.",
                "Arcane Flows - \nReduces the cooldown of your Presence of Mind, \nArcane Power and Invisibility spells by \n15% (1/2) \n30% (2/2) \nand the cooldown of your Evocation spell by \n1 min (1/2) \n2 min (2/2).",
                "Mind Mastery - \nIncreases spell power by \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5) \nof your total Intellect.",
                "Slow - \nReduces target's movement speed by 60%, increases the time between \nranged attacks by 60% and increases casting time by 30%.  \nLasts 15 sec.  Slow can only affect one target at a time.",
                "Missile Barrage - \nGives your Arcane Blast a \n8% (1/5) \n16% (2/5) \n24% (3/5) \n32% (4/5) \n40% (5/5) \nchance, and your Arcane Barrage, Fireball, \nFrostbolt and Frostfire Bolt spells a \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5) \nchance to reduce the channeled duration of the next Arcane Missiles \nspell by 2.5 secs, reduce the mana cost by 100%, \nand missiles will fire every .5 secs.",
                "Netherwind Presence - \nIncreases your spell haste by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Spell Power - \nIncreases critical strike damage bonus of all spells by \n25% (1/2) \n50% (2/2).",
                "Arcane Barrage - \nLaunches several missiles at the enemy target, \ncausing 386 to 470 Arcane damage.",
                "Improved Fire Blast - \nReduces the cooldown of your Fire Blast spell by \n1 sec (1/2) \n2 sec (2/2).",
                "Incineration - \nIncreases the critical strike chance of your Fire Blast, \nScorch, Arcane Blast and Cone of Cold spells by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Improved Fireball - \nReduces the casting time of your Fireball spell by \n0.1 sec (1/5) \n0.2 sec (2/5) \n0.3 sec (3/5) \n0.4 sec (4/5) \n0.5 sec (5/5).",
                "Ignite - \nYour critical strikes from Fire damage spells cause \nthe target to burn for an additional \n8% (1/5) \n16% (2/5) \n24% (3/5) \n32% (4/5) \n40% (5/5) \nof your spell's damage over 4 sec.",
                "Burning Determination - \nWhen Interrupted or Silenced you have a \n50% (1/2) \n100% (2/2) \nchance to become immune to the next Interrupt \nor Silence mechanic.  Lasts 20 sec.",
                "World in Flames - \nIncreases the critical strike chance of your Flamestrike, \nPyroblast, Blast Wave, Dragon's Breath, Living Bomb, \nBlizzard and Arcane Explosion spells by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Flame Throwing - \nIncreases the range of all Fire spells except Frostfire Bolt by \n3 yards (1/2) \n6 yards (2/2).",
                "Impact - \nGives your damaging spells a \n4% (1/3) \n7% (2/3) \n10% (3/3) \nchance to cause the next Fire Blast you cast \nto stun the target for 2 sec.",
                "Pyroblast - \nHurls an immense fiery boulder that causes 141 to 187 Fire \ndamage and an additional 56 Fire damage over 12 sec.",
                "Burning Soul - \nReduces the pushback suffered from damaging attacks \nwhile casting Fire spells by \n35% (1/2) \n70% (2/2) \nand reduces the threat caused by your Fire spells by \n10% (1/2) \n20% (2/2).",
                "Improved Scorch - \nIncreases your chance to critically hit with Scorch, Fireball and \nFrostfire Bolt by an additional \n1% (1/3) \n2% (2/3) \n3% (3/3) \nand your damaging Scorch spells have a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to cause your target to be vulnerable to spell damage, \nincreasing spell critical strike chance against that \ntarget by 5% and lasts 30 sec.",
                "Molten Shields - \nCauses your Fire Ward and Frost Ward spells to have a \n15% (1/2) \n30% (2/2) \nchance to reflect the warded spell while active. \nIn addition, your Molten Armor has a \n50% (1/2) \n100% (2/2) \nchance to affect ranged and spell attacks.",
                "Master of Elements - \nYour spell criticals will refund \n10% (1/3) \n20% (2/3) \n30% (3/3) \nof their base mana cost.",
                "Playing with Fire - \nIncreases all spell damage caused by \n1% (1/3) \n2% (2/3) \n3% (3/3) \nand all spell damage taken by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Critical Mass - \nIncreases the critical strike chance of your Fire spells by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Blast Wave - \nA wave of flame radiates outward from the caster, \ndamaging all enemies caught within the blast for 154 to 186 Fire damage, \nknocking them back and dazing them for 6 sec.",
                "Blazing Speed - \nGives you a \n5% (1/2) \n10% (2/2) \nchance when hit by a melee or ranged attack to increase your \nmovement speed by 50% and dispel all movement impairing effects.  \nThis effect lasts 8 sec.",
                "Fire Power - \nIncreases the damage done by your Fire spells by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5).",
                "Pyromaniac - \nIncreases chance to critically hit by \n1% (1/3) \n2% (2/3) \n3% (3/3) \nand allows \n17% (1/3) \n33% (2/3) \n50% (3/3) \nof your mana regeneration to continue while casting.",
                "Combustion - \nWhen activated, this spell increases your critical strike damage bonus \nwith Fire damage spells by 50%, and causes each of your \nFire damage spell hits to increase your critical strike chance \nwith Fire damage spells by 10%.  \nThis effect lasts until you have caused 3 non-periodic \ncritical strikes with Fire spells.",
                "Molten Fury - \nIncreases damage of all spells against \ntargets with less than 35% health by \n6% (1/2) \n12% (2/2).",
                "Fiery Payback - \nWhen below 35% health all damage taken is reduced by \n10% (1/2) \n20% (2/2) \nand your Pyroblast spell's cast time is reduced by \n1.75 secs (1/2) \n3.5 secs (2/2) \nwhile the cooldown is increased by \n2.5 secs (1/2) \n5 secs (2/2).  \nIn addition, melee and ranged attacks made against you have a \n5% (1/2) \n10% (2/2) \nchance to disarm your attacker's main hand and ranged weapons.",
                "Empowered Fire - \nIncreases the damage of your Fireball, Frostfire Bolt and Pyroblast spells by an amount equal to \n5% (1/3) \n10% (2/3) \n15% (3/3) \nof your spell power.  \nIn addition, each time your Ignite talent causes damage, you have a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to regain 2% of your base mana.",
                "Firestarter - \nYour damaging Blast Wave and Dragon's Breath spells have a \n50% (1/2) \n 100% (2/2) \nchance to make your next Flamestrike spell instant cast and cost no mana.  \nLasts 10 sec.",
                "Dragon's Breath - \nTargets in a cone in front of the caster take 370 to 430 Fire damage \nand are Disoriented for 5 sec.  Any direct damaging attack will revive targets.  \nTurns off your attack when used.",
                "Hot Streak - \nAny time you score 2 non-periodic spell criticals in a row using Fireball, \nFire Blast, Scorch, Living Bomb, or Frostfire Bolt, you have a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance the next Pyroblast spell cast \nwithin 10 sec will be instant cast.",
                "Burnout - \nIncreases your spell critical damage bonus with all spells by \n10% (1/5) \n20% (2/5) \n30% (3/5) \n40% (4/5) \n50% (5/5) \nbut your non-periodic spell criticals cost an additional \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5) \nof the spell's cost.",
                "Living Bomb - \nThe target becomes a Living Bomb, taking 612 Fire damage over 12 sec.  \nAfter 12 sec or when the spell is dispelled, the target explodes \ndealing 306 Fire damage to all enemies within 10 yards.",
                "Frostbite - \nGives your Chill effects a \n5% (1/3) \n10% (2/3) \n15% (3/3) \nchance to freeze the target for 5 sec.",
                "Improved Frostbolt - \nReduces the casting time of your Frostbolt spell by \n0.1 sec (1/5) \n0.2 sec (2/5) \n0.3 sec (3/5) \n0.4 sec (4/5) \n0.5 sec (5/5).",
                "Ice Floes - \nReduces the cooldown of your Frost Nova, Cone of Cold, \nIce Block and Icy Veins spells by \n7% (1/3) \n14% (2/3) \n20% (3/3).",
                "Ice Shards - \nIncreases the critical strike damage bonus of your Frost spells by \n33% (1/3) \n66% (2/3) \n100% (3/3).",
                "Frost Warding - \nIncreases the armor and resistances given by your \nFrost Armor and Ice Armor spells by \n25% (1/2) \n50% (2/2).  \nIn addition, gives your Frost Ward and Fire Ward a \n15% (1/2) \n30% (2/2) \nchance to negate the warded damage spell and restore \nmana equal to the damage caused.",
                "Precision - \nReduces the mana cost and increases your chance to hit with spells by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Permafrost - \nIncreases the duration of your Chill effects by \n1 sec (1/3) \n2 secs (2/3) \n3 secs (3/3), \nreduces the target's speed by an additional \n4% (1/3) \n7% (2/3) \n10% (3/3), \nand reduces the target's healing received by \n7% (1/3) \n13% (2/3) \n20% (3/3).",
                "Piercing Ice - \nIncreases the damage done by your Frost spells by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Icy Veins - \nHastens your spellcasting, increasing spell casting speed by 20% \nand reduces the pushback suffered from damaging attacks \nwhile casting by 100%.  Lasts 20 sec.",
                "Improved Blizzard - \nAdds a chill effect to your Blizzard spell.  \nThis effect lowers the target's movement speed by \n25% (1/3) \n40% (2/3) \n50% (3/3).  \nLasts 1.50 sec.",
                "Arctic Reach - \nIncreases the range of your Frostbolt, Ice Lance, Deep Freeze \nand Blizzard spells and the radius of your \nFrost Nova and Cone of Cold spells by \n10% (1/2) \n20% (2/2).",
                "Frost Channeling - \nReduces the mana cost of all spells by \n4% (1/3) \n7% (2/3) \n10% (3/3) \nand reduces the threat caused by your Frost spells by \n4% (1/3) \n7% (2/3) \n10% (3/3).",
                "Shatter - \nIncreases the critical strike chance of all \nyour spells against frozen targets by \n17% (1/3) \n34% (2/3) \n50% (3/3).",
                "Cold Snap - \nWhen activated, this spell finishes the cooldown \non all Frost spells you recently cast.",
                "Improved Cone of Cold - \nIncreases the damage dealt by your Cone of Cold spell by \n15% (1/3) \n25% (2/3) \n35% (3/3).",
                "Frozen Core - \nReduces the damage taken from all spells by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Cold as Ice - \nReduces the cooldown of your Cold Snap, \nIce Barrier and Summon Water Elemental spells by \n10% (1/2) \n20% (2/2).",
                "Winter's Chill - \nIncreases your chance to critically hit with \nFrostbolt by an additional \n1% (1/3) \n2% (2/3) \n3% (3/3) \nand gives your Frost damage spells a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to apply the Winter's Chill effect, which increases \nthe chance spells will critically hit the target \nby 1% for 15 sec.  Stacks up to 5 times.",
                "Shattered Barrier - \nGives your Ice Barrier spell a \n50% (1/2) \n100% (2/2) \nchance to freeze all enemies within 10 yds \nfor 8 sec when it is destroyed.",
                "Ice Barrier - \nInstantly shields you, absorbing 438 damage.  Lasts 1 min.  \nWhile the shield holds, spellcasting will not be delayed by damage.",
                "Arctic Winds - \nIncreases all Frost damage you cause by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5) \nand reduces the chance melee and ranged attacks will hit you by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Empowered Frostbolt - \nIncreases the damage of your Frostbolt spell by an amount equal to \n5% (1/2) \n10% (2/2) \nof your spell power and reduces the cast time by \n0.1 sec (1/2) \n0.2 sec (2/2).",
                "Fingers of Frost - \nGives your Chill effects a \n7% (1/2) \n15% (2/2) \nchance to grant you the Fingers of Frost effect, which treats your \nnext 2 spells cast as if the target were Frozen.  \nLasts 15 sec.",
                "Brain Freeze - \nYour Frost damage spells with chilling effects have a \n5% (1/3) \n10% (2/3) \n15% (3/3) \nchance to cause your next Fireball or Frostfire Bolt spell \nto be instant cast and cost no mana.",
                "Summon Water Elemental - \nSummon a Water Elemental to fight for the caster for 45 sec.",
                "Enduring Winter - \nIncreases the duration of your Summon Water Elemental spell by \n5 sec (1/3) \n10 sec (2/3) \n15 sec (3/3) \nand your Frostbolt spell has a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to grant up to 10 party or raid members mana \nregeneration equal to 1% of their maximum mana per 5 sec for 15 sec.  \nThis effect cannot occur more often than once every 6 sec.",
                "Chilled to the Bone - \nIncreases the damage caused by your Frostbolt, \nFrostfire Bolt and Ice Lance spells by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5) \nand reduces the movement speed of all chilled targets by an additional \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5).",
                "Deep Freeze - \nStuns the target for 5 sec.  Only usable on Frozen targets.  \nDeals 1469 to 1741 damage to targets permanently immune to stuns.",
            };
            return array;
        }
        private readonly static string[] TitleInfo = 
        {
            "Arcane",
            "Fire",
            "Frost",
        };
    }
}