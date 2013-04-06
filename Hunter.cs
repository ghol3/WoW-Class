using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TalentCalculator
{
    class Hunter : ControlClass
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
                0,3,11,12,15,18,21,23,27,29,31,35,36,38,39,40,42,43,
                47,51,56,59,63,65,66,71,72,75,79,80,82,83,84,86,87,
                91,100,102,107,109,111,115,118,119,122,124,125,127,
                128,130,131, 
            };
            return array;
        }

        public int[] AbilityValue()
        {
            int[] array = new int[]
            {
                    5,5,2,3,3,2,2,1,5,2,5,
                    2,1,2,2,5,3,1,3,2,5,3,
                    1,3,5,1,
                    2,3,5,3,3,5,2,3,1,2,3,
                    5,2,1,3,2,3,3,1,3,5,2,
                    3,1,3,5,1,
                    5,3,2,3,3,3,2,5,1,3,2,
                    3,3,3,3,1,5,3,3,1,3,5,
                    3,2,1,3,3,1,
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
            26,
            53,
        };
        public string[] AbilityInfo()
        {
            string[] array = new string[]{
                "Improved Aspect of the Hawk - \nWhile Aspect of the Hawk or Dragonhawk is active, \nall normal ranged attacks have a 10% chance of increasing \nranged attack speed by \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5) \nfor 12 sec.",
                "Endurance Training - \nIncreases the health of your pet by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5) \nand your total health by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Focused Fire - \nAll damage caused by you is increased by \n1% (1/2) \n2% (2/2) \nwhile your pet is active and the critical strike \nchance of your pet's special abilities is increased by \n10% (1/2) \n20% (2/2) \nwhile Kill Command is active.",
                "Improved Aspect of the Monkey - \nIncreases the Dodge bonus of your Aspect of the Monkey and \nAspect of the Dragonhawk by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Thick Hide - \nIncreases the armor rating of your pets by \n7% (1/3) \n14% (2/3) \n20% (3/3) \nand your armor contribution from items by \n4% (1/3) \n7% (2/3) \n10% (3/3).",
                "Improved Revive Pet - \nRevive Pet's casting time is reduced by \n3 sec (1/2) \n6 sec (2/2), \nmana cost is reduced by \n20% (1/2) \n40% (2/2), \nand increases the health your pet returns with by an additional \n15% (1/2) \n30% (2/2).",
                "Pathfinding - \nIncreases the speed bonus of your Aspect of \nthe Cheetah and Aspect of the Pack by \n4% (1/2) \n8% (2/2), \nand increases your speed while mounted by \n5% (1/2) \n10% (2/2). \nThe mounted movement speed increase does not stack with other effects.",
                "Aspect Mastery - \nAspect of the Viper - Reduces the damage penalty by 10%. \nAspect of the Monkey - Reduces the damage done to you while active by 5%.\nAspect of the Hawk - Increases the attack power bonus by 30%.\nAspect of the Dragonhawk - Combines the bonuses from Aspect of the Monkey and Hawk.",
                "Unleashed Fury - \nIncreases the damage done by your pets by \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5).",
                "Improved Mend Pet - \nReduces the mana cost of your Mend Pet spell by \n10% (1/2) \n20% (2/2) \nand gives the Mend Pet spell a \n25% (1/2) \n50% (2/2) \nchance of cleansing 1 Curse, Disease, \nMagic or Poison effect from the pet each tick.",
                "Ferocity - \nIncreases the critical strike chance of your pet by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5).",
                "Spirit Bond - \nWhile your pet is active, \nyou and your pet will regenerate \n1% (1/2) \n2% (2/2) \nof total health every 10 sec, \nand increases healing done to you and your pet by \n5% (1/2) \n10% (2/2).",
                "Intimidation - \nCommand your pet to intimidate the target, \ncausing a high amount of threat and stunning \nthe target for 3 sec. Lasts 15 sec.",
                "Bestial Discipline - \nIncreases the Focus regeneration of your pets by \n50% (1/2) \n100% (2/2).",
                "Animal Handler - \nIncreases your pet's attack power by \n5% (1/2) \n10% (2/2), \nand increases the duration of your Master's Call effect by \n3 sec (1/2) \n6 sec (2/2).",
                "Frenzy - \nGives your pet a \n20% (1/5) \n40% (2/5) \n60% (3/5) \n80% (4/5) \n100% (5/5) \nchance to gain a 30% attack speed increase for 8 sec \nafter dealing a critical strike.",
                "Ferocious Inspiration - \nAll party and raid members have all damage increased by \n1% (1/3) \n2% (2/3) \n3% (3/3) \nwithin 100 yards of your pet. \nIn addition, increases the damage dealt by Arcane Shot and Steady Shot by \n3% (1/3) \n6% (2/3) \n9% (3/3).",
                "Bestial Wrath - \nSend your pet into a rage causing 50% additional damage for 10 sec. \nWhile enraged, the beast does not feel pity or \nremorse or fear and it cannot be stopped unless killed.",
                "Catlike Reflexes - \nIncreases your chance to dodge by \n1% (1/3) \n2% (2/3) \n3% (3/3) \nand your pet's chance to dodge by an additional \n3% (1/3) \n6% (2/3) \n9% (3/3). \nIn addition, reduces the cooldown of your Kill Command ability by \n10 sec (1/3) \n20 sec (2/3) \n30 sec (3/3).",
                "Invigoration - \nWhen your pet scores a critical hit \nwith a special ability, you have a \n50% (1/2) \n100% (2/2) \nchance to instantly regenerate 1% mana.",
                "Serpent's Swiftness - \nIncreases ranged combat attack speed by \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5) \nand your pet's melee attack speed by \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5).",
                "Longevity - \nReduces the cooldown of your Bestial Wrath, \nIntimidation and Pet Special Abilities by \n10% (1/3) \n20% (2/3) \n30% (3/3).",
                "The Beast Within - \nIncreases all damage you deal by 10% and while your pet is \nunder the effects of Bestial Wrath, you also go into a \nrage causing 10% additional damage and reducing mana costs \nof all spells by 50% for 10 sec.  \nWhile enraged, you do not feel pity or remorse or \nfear and you cannot be stopped unless killed.",
                "Cobra Strikes - \nYou have a \n20% (1/3) \n40% (2/3) \n60% (3/3) \nchance when you critically hit with Arcane Shot, \nSteady Shot or Kill Shot to cause your pet's \nnext 2 special attacks to critically hit.",
                "Kindred Spirits - \nIncreases your pet's damage by \n4% (1/5) \n8% (2/5) \n12% (3/5) \n16% (4/5) \n20% (5/5) \nand you and your pet's movement speed by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5)\n while your pet is active. \nThis does not stack with other movement speed increasing effects.",
                "Beast Mastery - \nYou master the art of Beast training, teaching you the ability \nto tame Exotic pets and increasing your total amount of \nPet Skill Points by 4.",
                "Improved Concussive Shot - \nIncreases the duration of your Concussive Shot's daze effect by \n1 sec (1/2) \n2 sec (2/2).",
                "Focused Aim - \nReduces the pushback suffered from damaging attacks \nwhile casting Steady Shot by \n23% (1/3) \n46% (2/3) \n70% (3/3), \nand increases your chance to hit by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Lethal Shots - \nIncreases your critical strike chance with ranged weapons by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Careful Aim - \nIncreases your ranged attack power by an amount equal to \n33% (1/3) \n66% (2/3) \n100% (3/3) \nof your total Intellect.",
                "Improved Hunter's Mark - \nIncreases the bonus attack power granted \nby your Hunter's Mark ability by \n10% (1/3) \n20% (2/3) \n30% (3/3), \nand reduces the mana cost of your Hunter's Mark ability by \n33% (1/3) \n66% (2/3) \n100% (3/3).",
                "Mortal Shots - \nIncreases the critical strike damage bonus \nof your ranged abilities by \n6% (1/5) \n12% (2/5) \n18% (3/5) \n24% (4/5) \n30% (5/5).",
                "Go for the Throat - \nYour ranged critical hits cause your pet to generate \n25 (1/2) \n50 (2/2) \nFocus.",
                "Improved Arcane Shot - \nIncreases the damage done by your Arcane Shot by \n5% (1/3) \n10% (2/3) \n15% (3/3).",
                "Aimed Shot - \nAn aimed shot that increases ranged damage by 5 \nand reduces healing done to that target by 50%.  \nLasts 10 sec.",
                "Rapid Killing - \nReduces the cooldown of your Rapid Fire ability by \n1 min (1/2) \n2 min (2/2).  \nIn addition, after killing an opponent that yields \nexperience or honor, your next Aimed Shot, \nArcane Shot or Chimera Shot causes \n10% (1/2) \n20% (2/2) \nadditional damage.  \nLasts 20 sec.",
                "Improved Stings - \nIncreases the damage done by your \nSerpent Sting and Wyvern Sting by \n10% (1/3) \n20% (2/3) \n30% (3/3) \nand the mana drained by your Viper Sting by \n10% (1/3) \n20% (2/3) \n30% (3/3).  \nIn addition, reduces the chance your \nSting damage over time effects will be dispelled by \n10% (1/3) \n20% (2/3) \n30% (3/3).",
                "Efficiency - \nReduces the Mana cost of your Shots and Stings by \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5).",
                "Concussive Barrage - \nYour successful Chimera Shot and \nMulti-Shot attacks have a \n50% (1/2) \n100% (2/2) \nchance to Daze the target for 4 sec.",
                "Readiness - \nWhen activated, this ability immediately finishes the cooldown\n on your other Hunter abilities except Bestial Wrath.",
                "Barrage - \nIncreases the damage done by your Multi-Shot, \nAimed Shot, and Volley spells by \n4% (1/3) \n8% (2/3) \n12% (3/3).",
                "Combat Experience - \nIncreases your total Agility and Intellect by \n2% (1/2) \n4% (2/2).",
                "Ranged Weapon Specialization - \nIncreases the damage you deal with ranged weapons by \n1% (1/3) \n3% (2/3) \n5% (3/3).",
                "Piercing Shots - \nYour critical Aimed, Steady and Chimera Shots cause \nthe target to bleed for \n10% (1/3) \n20% (2/3) \n30% (3/3) \nof the damage dealt over 8 sec.",
                "Trueshot Aura - \nIncreases the attack power of party and raid members\n within 100 yards by 10%.  \nLasts until cancelled.",
                "Improved Barrage - \nIncreases the critical strike chance of your \nMulti-Shot and Aimed Shot abilities by \n4% (1/3) \n8% (2/3) \n12% (3/3) \nand reduces the pushback suffered from damaging attacks \nwhile channeling Volley by \n33% (1/3) \n66% (2/3) \n100% (3/3).",
                "Master Marksman - Increases your critical strike chance by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5), \nand reduces the Mana cost of your Steady Shot, \nAimed Shot, and Chimera Shot by \n5% (1/5) \n10% (2/5) \n15% (3/5) \n20% (4/5) \n25% (5/5).",
                "Rapid Recuperation - \nYou gain \n2% (1/2) \n4% (2/2) \nof your mana every 3 sec while under \nthe effect of Rapid Fire, and you gain \n2% (1/2) \n4% (2/2) \nof your mana every 2 sec for 6 sec when you gain Rapid Killing.",
                "Wild Quiver - \nYou have a \n4% (1/3) \n8% (2/3) \n12% (3/3) \nchance to shoot an additional shot when doing \ndamage with your auto shot, dealing 80% weapon nature damage. \nWild Quiver consumes no ammo.",
                "Silencing Shot - \nA shot that deals 50% weapon damage and Silences the target for 3 sec.  \nNon-player victim spellcasting is also interrupted for 3 sec.",
                "Improved Steady ShotYour Steady Shot hits have a \n5% (1/3) \n10% (2/3) \n15% (3/3) \nchance to increase the damage \ndone by your next Aimed Shot, Arcane Shot or \nChimera Shot by 15%, and reduce the mana cost of \nyour next Aimed Shot, Arcane Shot or Chimera Shot by 20%.",
                "Marked for Death - \nIncreases your damage done by your shots \nand the damage done by your pet's special abilities by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5) \non marked targets, and increases the \ncritical strike damage bonus of your Aimed Shot, \nArcane Shot, Steady Shot, Kill Shot and Chimera Shot by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5).",
                "Chimera Shot - \nYou deal 125% weapon damage, refreshing the current \nSting on your target and triggering an effect:\n\nSerpent Sting - Instantly deals 40% of the damage done by your Serpent Sting.\n\nViper Sting - Instantly restores mana to you equal to 60% of the total amount drained by your Viper Sting.\n\nScorpid Sting - Attempts to Disarm the target for 10 sec. \nThis effect cannot occur more than once per 1 minute.",
                "Improved Tracking - \nWhile tracking Beasts, Demons, Dragonkin, Elementals, Giants, \nHumanoids and Undead, all damage done to those \ntypes by the Hunter is increased by \n1% (1/5) \n2% (2/5) \n3% (3/5) \n4% (4/5) \n5% (5/5).",
                "Hawk Eye - Increases the range of your ranged weapons by \n2 yards (1/3) \n4 yards (2/3) \n6 yards (3/3).",
                "Savage Strikes - \nIncreases the critical strike chance of Raptor Strike, Mongoose Bite and Counterattack by \n10% (1/2) \n20% (2/2).",
                "Surefooted - \nReduces the duration of movement impairing effects by \n10% (1/3) \n20% (2/3) \n30% (3/3).",
                "Entrapment - \nWhen your Frost Trap or Snake Trap are triggered you \nentrap all afflicted targets, \npreventing them from moving for \n2 sec (1/2) \n3 sec (2/2) \n4 sec (3/3).",
                "Trap Mastery - \nFrost Trap and Freezing Trap - Increases the duration by \n10% (1/3) \n20% (2/3) \n30% (3/3).\n\nImmolation Trap, Explosive Trap and Black Arrow - \nIncreases the periodic damage done by \n10% (1/3) \n20% (2/3) \n30% (3/3).\n\nSnake Trap - Increases the number of snakes summoned by \n2 (1/3) \n4 (2/3) \n6 (3/3).",
                "Survival Instincts - \nReduces all damage taken by \n2% (1/2) \n4% (2/2) \nand increases the critical strike chance of your \nArcane Shot, Steady Shot, and Explosive Shot by \n2% (1/2) \n4% (2/2).",
                "Survivalist - \nIncreases your Stamina by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5).",
                "Scatter Shot - \nA short-range shot that deals 50% weapon damage and disorients \nthe target for 4 sec.  Any damage caused will remove the effect.  \nTurns off your attack when used.",
                "Deflection - \nIncreases your chance to parry by \n1% (1/3) \n2% (2/3) \n3% (3/3), \nand reduces the duration of all Disarm effects \nused against you by \n16% (1/3) \n25% (2/3) \n50% (3/3).  \nThis does not stack with other Disarm duration reducing effects.",
                "Survival Tactics - \nReduces the chance your Feign Death ability and \nall trap spells will be resisted by \n2% (1/2) \n4% (2/2), \nand reduces the cooldown of your Disengage ability by \n2 sec (1/2) \n4 sec (2/2).",
                "T.N.T. - \nIncreases the damage done by your Explosive Shot,  \nExplosive Trap, Black Arrow and Immolation Trap by \n2% (1/3) \n4% (2/3) \n6% (3/3).",
                "Lock and Load - \nYou have a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance when you trap a target with Freezing Trap, \nFreezing Arrow or Frost Trap and a \n2% (1/3) \n4% (2/3) \n6% (3/3) \nchance when you deal periodic damage with your Immolation Trap, \nExplosive Trap or Black Arrow to cause your next 2 Arcane Shot \nor Explosive Shot spells to trigger no cooldown, \ncost no mana and consume no ammo. \nThis effect has a 22 sec cooldown.",
                "Hunter vs. Wild - \nIncreases you and your pet's attack power and ranged attack power equal to \n10% (1/3) \n20% (2/3) \n30% (3/3) \nof your total Stamina.",
                "Killer Instinct - \nIncreases your critical strike chance with all attacks by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Counterattack - \nA strike that becomes active after parrying an opponent's attack.  \nThis attack deals 50 damage and immobilizes the target for 5 sec. \nCounterattack cannot be blocked, dodged, or parried.",
                "Lightning Reflexes - \nIncreases your Agility by \n3% (1/5) \n6% (2/5) \n9% (3/5) \n12% (4/5) \n15% (5/5).",
                "Resourcefulness - \nReduces the mana cost of all traps, melee abilities and \nBlack Arrow by \n20% (1/3) \n40% (2/3) \n60% (3/3) \nand reduces the cooldown of all traps and Black Arrow by \n2 sec (1/3) \n4 sec (2/3) \n6 sec (3/3).",
                "Expose Weakness - \nYour ranged criticals have a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to grant you Expose Weakness. \nExpose Weakness increases your attack power \nby 25% of your Agility for 7 sec.",
                "Wyvern Sting - \nA stinging shot that puts the target to sleep for 30 sec. \nAny damage will cancel the effect.  When the target wakes up, \nthe Sting causes 300 Nature damage over 6 sec.  \nOnly one Sting per Hunter can be active on the target at a time.",
                "Thrill of the Hunt - \nGives you a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to regain 40% of the mana cost of any shot \nwhen it critically hits.",
                "Master Tactician - \nYour successful ranged attacks have a 10% chance to increase \nyour critical strike chance with all attacks by \n2% (1/5) \n4% (2/5) \n6% (3/5) \n8% (4/5) \n10% (5/5) \nfor 8 sec.",
                "Noxious Stings - \nIf Wyvern Sting is dispelled, the dispeller is also \nafflicted by Wyvern Sting lasting \n16% (1/3) \n25% (2/3) \n50% (3/3) \nof the duration remaining, and increases all damage done \nby you on targets afflicted by your Serpent Sting by \n1% (1/3) \n2% (2/3) \n3% (3/3).",
                "Point of No Escape - \nIncreases the critical strike chance of all of your attacks on \ntargets affected by your Frost Trap, Freezing Trap and \nFreezing Arrow by \n3% (1/2) \n6% (2/2).",
                "Black Arrow - \nFires a Black Arrow at the target, increasing all damage done by you to \nthe target by 6% and dealing 786 Shadow damage over 15 sec. \nBlack Arrow shares a cooldown with Trap spells.",
                "Sniper Training - \nIncreases the critical strike chance of \nyour Kill Shot ability by \n5% (1/3) \n10% (2/3) \n15% (3/3), \nand while standing still for 6 sec, you gain Sniper Training \nincreasing the damage done by your Steady Shot, Aimed Shot, \nBlack Arrow and Explosive Shot by \n2% (1/3) \n4% (2/3) \n6% (3/3) \nfor 15 sec.",
                "Hunting Party - \nIncreases your total Agility by an additional \n1% (1/3) \n2% (2/3) \n3% (3/3), \nand your Arcane Shot, Explosive Shot and \nSteady Shot critical strikes have a \n33% (1/3) \n66% (2/3) \n100% (3/3) \nchance to grant up to 10 party or raid members mana \nregeneration equal to 1% of the maximum mana per 5 sec. \nLasts for 15 sec.",
                "Explosive Shot - \nYou fire an explosive charge into the enemy target, dealing 146-174 Fire damage. \nThe charge will blast the target every second for an additional 2 sec.",
            };
            return array;
        }
        private readonly static string[] TitleInfo = 
        {
            "Beast Mastery",
            "Marksmanship",
            "Survival",
        };
    }
}