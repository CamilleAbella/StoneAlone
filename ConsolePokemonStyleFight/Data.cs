﻿using System.Collections.Generic;
using System.Drawing;
using ConsolePokemonStyleFight.Entities;
using Pastel;

namespace ConsolePokemonStyleFight
{
    public class Data
    {
        public enum StatName
        {
            Health,
            Strength,
            Weight,
            Defense,
            Dodge,
            RadioActivity,
            Psychology,
            Respect,
            Money,
        }
        
        public static string ColonyName = "Stone Alone Colony";

        public static string TitleScreen = (
                                               "\n\n" +
                                               "  ____  ____  __   __ _  ____     __   __     __   __ _  ____ \n" +
                                               " / ___)(_  _)/  \\ (  ( \\(  __)   / _\\ (  )   /  \\ (  ( \\(  __)\n" +
                                               " \\___ \\  )( (  O )/    / ) _)   /    \\/ (_/\\(  O )/    / ) _) \n" +
                                               " (____/ (__) \\__/ \\_)__)(____)  \\_/\\_/\\____/ \\__/ \\_)__)(____)"
                                           ).Pastel(Color.LawnGreen) +
                                           "\n\n" +
                                           "     ┌───────────────────────────────────────────────────┐\n" +
                                           "     │                                                   │\n" +
                                           "     │  Hello!                                           │\n" +
                                           "     │                                                   │\n" +
                                           "     │ You are the leader of a post apocalyptic colony.  │\n" +
                                           "     │ Survive long enough for reinforcements to arrive. │\n" +
                                           "     │ Enjoy!                                            │\n" +
                                           "     │                                           Ghom    │\n" +
                                           "     └───────────────────────────────────────────────────┘\n";

        public static string LoseMail()
        {
            return "\n\n" +
                  "     ┌──────────────────────────────────────────────────────────────────────────┐\n" +
                  "     │                                                                          │\n" +
                  $"     │  {"You lose...".Pastel(Color.Red)}                                                             │\n" +
                  "     │                                                                          │\n" +
                  "     │ The following statistics have a too critical rate,                       │\n" +
                  $"     │ {SizedString.Constrain($"{ColoredColonyName()} is on the verge of collapse.", 73, SizedString.Alignment.Left)}│\n" +
                  "     │ Disappointing.                                                           │\n" +
                  "     │                                                                  Ghom    │\n" +
                  "     └──────────────────────────────────────────────────────────────────────────┘\n"; 
        }

        public static string NukeBomb = "\n" +
                                        "                                        _.-^^---....,,--\n" +
                                        "                                    _--                  --_\n" +
                                        "                                   <                        >)\n" +
                                        "                                   |                         |\n" +
                                        "                                    \\._                   _./\n" +
                                        "                                       ```--. . , ; .--'''\n" +
                                        "                                             | |   |\n" +
                                        "                                          .-=||  | |=-.\n" +
                                        "                                          `-=#$%&%$#=-'\n" +
                                        "                                             | ;  :|\n" +
                                        "                                    _____.,-#%&$@%#&#~,._____";

        public static string ColoredColonyName()
        {
            return ColonyName.Pastel(Color.LawnGreen);
        }

        public static readonly List<Action> Actions = new ()
        {
            new (
                "Want a chocolate bar?".Pastel(Color.BlueViolet), 
                new []{ StatName.Health, StatName.Weight },
                new []{ StatName.Dodge }, 
                new []{ StatName.Psychology },
                new []{ StatName.Weight },
                null,
                null,
                null
            ),
            new (
                $"Should {ColoredColonyName()} {"use nuclear".Pastel(Color.BlueViolet)} power?", 
                new []{ StatName.RadioActivity, StatName.Money },
                null,
                null,
                new []{ StatName.RadioActivity },
                null,
                null,
                null
            ),
            new (
                $"{"Free the miners".Pastel(Color.BlueViolet)} from the uranium quarry!",
                new [] { StatName.Respect },
                new [] { StatName.Money },
                new [] { StatName.Money, StatName.RadioActivity },
                new [] { StatName.Respect },
                null,
                null,
                null
            ),
            new (
                $"Should we {"increase the price".Pastel(Color.BlueViolet)} of the fallout suit?",
                new [] { StatName.Money },
                new [] { StatName.Respect },
                new [] { StatName.Respect, StatName.Psychology },
                null,
                null,
                null,
                null
            ),
            new (
                $"Shouldn't we {"barricade the colony?".Pastel(Color.BlueViolet)}",
                new [] { StatName.Defense, StatName.Respect },
                new [] { StatName.Money },
                new [] { StatName.Psychology },
                null,
                null,
                null,
                null // isBarricaded = true
            ),
            new (
                $"Zombie invasion! {"Defend us!".Pastel(Color.BlueViolet)}",
                new [] { StatName.Respect, StatName.Strength },
                new [] { StatName.Health },
                new [] { StatName.RadioActivity, StatName.Weight },
                new [] { StatName.Respect, StatName.Psychology },
                null,
                null,
                null // si pas assez de force, game over
            ),
            new (
                $"I am working on a nuclear fusion engine, please {"help my work.".Pastel(Color.BlueViolet)}",
                new [] { StatName.Respect },
                new [] { StatName.RadioActivity, StatName.Money },
                null,
                new [] { StatName.Respect },
                null,
                null,
                null
            ),
            new (
                "A new nuclear reactor must be opened.",
                new [] { StatName.RadioActivity, StatName.Money },
                new [] { StatName.Respect },
                new [] { StatName.Respect },
                new [] { StatName.Money },
                null,
                null,
                null
            ),
            new (
                $"Hey you! {"Give your money.".Pastel(Color.BlueViolet)}",
                new [] { StatName.Psychology },
                new [] { StatName.Money },
                new [] { StatName.Respect, StatName.Strength },
                new [] { StatName.Health },
                null,
                null,
                null
            ),
            new (
                $"Come on, let's {"train to fight!".Pastel(Color.BlueViolet)}",
                new [] { StatName.Strength, StatName.Dodge },
                new [] { StatName.Weight },
                new [] { StatName.Weight },
                new [] { StatName.Strength, StatName.Dodge },
                null,
                null,
                null
            ),
            new (
                $"Come with me to {"taste the last burger".Pastel(Color.BlueViolet)} of McDonuke.",
                new [] { StatName.Weight, StatName.Health },
                new [] { StatName.Dodge, StatName.Money, StatName.Strength },
                new [] { StatName.Psychology },
                null,
                null,
                null,
                null
            ),
            new (
                $"Nmmmm.. nmmmm... nmaaaah (A zombie is attacking you, you want to {"run away?".Pastel(Color.BlueViolet)})",
                new [] { StatName.Dodge },
                new [] { StatName.Weight, StatName.Psychology },
                new [] { StatName.Psychology },
                new [] { StatName.Health },
                null,
                null,
                null
            ),
            new (
                $"Anti-nuclear rebellion erupts, do you want to {"hear their arguments?".Pastel(Color.BlueViolet)}",
                new [] { StatName.Respect },
                new [] { StatName.Money, StatName.RadioActivity },
                null,
                new [] { StatName.Respect, StatName.Health },
                null,
                null,
                null
            ),
            new (
                $"Oh my God you're hurt! {"Let me take care of you.".Pastel(Color.BlueViolet)}",
                new [] { StatName.Health },
                new [] { StatName.Dodge, StatName.Money },
                new [] { StatName.Strength, StatName.Psychology },
                new [] { StatName.Defense },
                null,
                game => game.player.GetStat(StatName.Health).ToPercent() < 50,
                null
            ),
            new (
                "Politics sucks.".Pastel(Color.BlueViolet),
                new [] { StatName.Respect },
                new [] { StatName.Psychology },
                new [] { StatName.Psychology },
                new [] { StatName.Respect },
                null,
                null,
                null
            ),
            new (
                $"I am a ghoul, I love you! {"Make me a child.".Pastel(Color.BlueViolet)}",
                new [] { StatName.RadioActivity },
                new [] { StatName.Health },
                new [] { StatName.Psychology, StatName.Dodge },
                null,
                null,
                game => !game.player.IsInCoupleWithTheGhoul,
                (game, yes) => game.player.IsInCoupleWithTheGhoul = yes
            ),
            new (
                $"I give you the title of \"Nuclear Man\", {"do you accept it?".Pastel(Color.BlueViolet)}",
                new [] { StatName.Respect },
                null,
                new [] { StatName.Respect },
                null,
                game => game.player.GetStat(StatName.RadioActivity).ToPercent() >= 80,
                game => game.player.GetStat(StatName.RadioActivity).ToPercent() >= 80 && !game.player.IsNuclearManProposed,
                (game, yes) =>
                {
                    if(yes) game.player.Flags.Add("Nuclear Man");
                    game.player.IsNuclearManProposed = true;
                }
            ),
            new (
                $"I want to add \"{"Cool".Pastel(Color.LawnGreen)}\" to the colony's name. {"It's ok ?".Pastel(Color.BlueViolet)}",
                null,
                new [] {StatName.Respect},
                null,
                new [] {StatName.Respect},
                null,
                null,
                (game, yes) => ColonyName  = yes ? "Cool " + ColonyName : ColonyName
            ),
            new (
                $"I sell you my experience. {"It's ok ?".Pastel(Color.BlueViolet)}",
                null,
                new [] { StatName.Money },
                null,
                null,
                null,
                null,
                (game, yes) =>
                {
                    if(yes) game.player.GainExperience(game.CurrentPNJ().Level);
                }
            ),
            // new (
            //     $"I want to add \"Cool\" to the colony's name. {"It's ok ?".Pastel(Color.BlueViolet)}",
            //     null,
            //     null,
            //     null,
            //     null,
            //     null,
            //     null,
            //     null
            // ),
        };

        public static readonly List<PNJ> PNJList = new ()
        {
            new ("(￣ω￣)", 1),
            new ("ヽ(*・ω・)ﾉ", 1),
            new ("_:(´ཀ`」 ∠):_", 1),
            new ("〣( ºΔº )〣", 2),
            new ("┐(︶▽︶)┌", 2),
            new ("( ´-ω･)︻┻┳══━一", 2),
            new ("( ఠ ͟ʖ ఠ)", 3),
            new ("( ͡ಠ ʖ̯ ͡ಠ)", 3),
            new ("(‡▼益▼)", 3),
            new ("((╬◣﹏◢))", 3),
            new ("ψ(▼へ▼メ)～→", 4),
            new ("(凸ಠ益ಠ)凸", 4),
            new ("୧((#Φ益Φ#))୨", 5) // Boss
        };

        public static void Reset()
        {
            ColonyName = "Stone Alone Colony";
            PNJList.ForEach(pnj => pnj.Reset());
        }
    }
}