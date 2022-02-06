using System;

namespace Text_Adventure_Pirates_And_Kings
{
    class Program
    {
        static void Main(string[] args)
        {
            string castle = @" /                                       \
/   _   _   _                 _   _   _   \
|  | |_| |_| |   _   _   _   | |_| |_| |  |
|   \   _   /   | |_| |_| |   \   _   /   |
|    | | | |     \       /     | | | |    |
|    | |_| |______|     |______| |_| |    |
|    |              ___              |    |
|    |  _    _    (     )    _    _  |    |
|    | | |  |_|  (       )  |_|  | | |    |
|    | |_|       |       |       |_| |    |
|   /            |_______|            \   |
|  |___________________________________|  |
\         Pirates and Kings Textadventure
 \_______________________________________/
";


            string castle2 = @" / \               / \
 /   \             /   \
(_____)           (_____)
 |   |  _   _   _  |   |
 | O |_| |_| |_| |_| O |
 |-  |          _  | - |
 |   |   - _^_     |   |
 |  _|    //|\\  - |   |
 |   |   ///|\\\   |  -|
 |-  |_  |||||||   |   |
 |   |   |||||||   |-  |
 |___|___|||||||___|___|
         (      (
          \      \
           )      )
           |      |
           (      (
            \      \";
            string spiders = @"       /      \         __      _\( )/_
    \  \  ,,  /  /   | /  \ |    /(O)\ 
     '-.`\()/`.-'   \_\\  //_/    _.._   _\(o)/_  //  \\
    .--_'(  )'_--.   .'/()\'.   .'    '.  /(_)\  _\\()//_
   / /` /`""`\ `\ \   \\  //   /   __   \       / //  \\ \
    |  |  ><  |  |          ,  |   ><   |  ,     | \__/ |
    \  \      /  /         . \  \      /  / .              _
   _    '.__.'    _\(O)/_   \_'--`(  )'--'_/     __     _\(_)/_
_\( )/_            /(_)\      .--'/()\'--.    | /  \ |   /(O)\
 /(O)\  //  \\         _     /  /` '' `\  \  \_\\  //_/
       _\\()//_     _\(_)/_    |        |      //()\\ 
 jgs  / //  \\ \     /(o)\      \      /       \\  //
       | \__/ |";

            string maskedman = @"      ░░                                  
      ▒▒▒▒                                
      ▒▒▒▒    ██████████████████          
      ▒▒    ██                  ██        
                                ██        
                ▓▓▓▓▓▓████▓▓██▓▓██        
        ▓▓  ▓▓▓▓▒▒▒▒▒▒▒▒██▒▒▓▓▒▒██████    
      ████▒▒▓▓▓▓▓▓▓▓  ██  ░░░░▓▓██  ████  
    ██                                  ██
      ██████░░░░░░░░░░░░░░░░░░░░████████  
          ██░░░░░░░░  ████░░██  ██        
          ██░░░░░░░░  ████░░██  ██        
            ██░░░░██░░    ░░  ░░██        
        ████████░░░░██████░░░░████        
      ██        ██░░░░░░░░░░██    ██      
    ██            ██████████        ██    
  ██        ██      ▓▓      ██        ██  
  ██    ██████      ▓▓      ██████    ██  
  ██░░░░░░████      ▓▓      ████░░░░░░██  
  ██░░░░░░████      ▓▓      ████░░░░░░██  
    ██████  ██      ▓▓      ██  ██████    
          ██    ░░░░░░░░      ██          
        ██      ░░  ██          ██        
      ████░░  ░░  ██  ██        ████      
  ████▓▓▓▓▓▓░░░░██      ██░░  ▓▓▓▓▓▓████  
██▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██
██████████████████      ██████████████████";
            string sprite = @"                        ▓▓▓▓▓▓▓▓▓▓▓▓              
                    ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒██▓▓          
                  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██        
                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒      
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██      
              ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    
              ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    
              ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    
              ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    
  ████        ██▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    
░░██▒▒██        ██▒▒▒▒▒▒▓▓▓▓    ▒▒▒▒▒▒▒▒▒▒▒▒██    
  ░░██▒▒██      ██▒▒▒▒▒▒▓▓▓▓      ▒▒▒▒▒▒▒▒██      
      ██▒▒██      ██▒▒▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒██      
      ░░██▓▓██      ██▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒██      
          ██▒▒██  ██▓▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██        
            ██████▓▓▓▓▓▓████▒▒▒▒▒▒▒▒▒▒██          
              ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓        
              ██▓▓▓▓▓▓▓▓██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓██      
";

            string gaurd = @"                   ░░                    
                  ▒▒▒▒▒▒    ░░░░▒▒▒▒                    
                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                    
                ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                    
              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                    
              ▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒                      
              ▒▒▒▒▒▒░░░░░░░░░░░░░░                      
              ░░▓▓▒▒░░░░░░░░░░░░░░                      
              ░░▒▒░░░░▒▒░░░░░░▒▒░░                      
              ░░▒▒░░░░▓▓░░░░░░▓▓░░              ░░░░    
              ░░░░░░░░░░░░░░░░░░░░              ░░░░░░  
                ▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒              ░░░░░░░░
                ▓▓▒▒▒▒░░░░░░░░▒▒▒▒            ░░░░░░░░░░
                  ▒▒▒▒░░░░░░▒▒▒▒              ░░░░░░░░░░
                  ▓▓▒▒▒▒▒▒▒▒▒▒▓▓                ░░░░░░  
                ▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓▓▓              ██▓▓▓▓  
        ██▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓      ▓▓▓▓▓▓▓▓
        ██▓▓▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░████▓▓▓▓      ██▓▓▓▓▓▓
      ▓▓▓▓▓▓▓▓▓▓░░▒▒▒▒▓▓▓▓▓▓▒▒▒▒░░██▓▓▓▓▓▓▒▒    ▓▓▓▓▓▓▓▓
      ▓▓▓▓▓▓▓▓▓▓░░░░░░▓▓▓▓▓▓░░░░  ██▓▓▓▓▓▓▓▓▓▓  ██▓▓▓▓▓▓
      ██▓▓▓▓▓▓▓▓░░░░░░▓▓▓▓▓▓░░    ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
    ▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓▓▓▒▒░░░░██▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓
    ██▓▓▓▓▓▓▓▓▓▓░░░░░░▓▓▓▓▓▓░░    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
  ██▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░▓▓▓▓▓▓      ▓▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▓▓
  ██▓▓▓▓▓▓▓▓██▓▓▒▒▒▒▒▒▓▓▒▒▒▒░░░░░░▓▓▓▓▓▓  ██▓▓▓▓▓▓▓▓▓▓▓▓
  ██▓▓▓▓▓▓▓▓██▓▓░░░░░░░░░░░░░░    ▓▓▓▓▓▓  ░░▓▓▓▓▓▓▓▓▓▓▓▓
  ██▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░        ▓▓▓▓▓▓▓▓    ░░▓▓▓▓▓▓▓▓░░    ";

             string running = "true";
            while (running == "true"){
                Console.WriteLine("Een Kleine disclaimer de Fights zijn erg door het systeem geleid en dus niet random, dit komt omdat dit project van scratch gemaakt is en het anders te ingewikkeld zou worden.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(castle);

                Console.WriteLine("Wat is je naam?");
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("vul een naam in");
                }
                else
                {
                    Console.WriteLine($"Welkom {name} in de wereld van Pirates And kings");
                }

                Console.WriteLine("In de wereld van PenK zijn een aantal graafschappen en koninkrijken 2 daarvan zijn op het moment op zoek naar inwoners \n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Het Machtige Koninkrijk van Ream");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("En het machtige graafschap Seayar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("gebaseerd op jouw keuze krijg je een andere verhaalijn dus in welk kingdom wil je geplaatst worden?");
                string kingdom = Console.ReadLine();
                if (kingdom == "ream" || kingdom =="Ream")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Je hebt gekozen voor ream");
                    Console.WriteLine("Transporting to Ream Capital");
                    Console.WriteLine($"[gaurd]: Hallo daar nieuweling ik ben een van wachters van Ream welkom {gaurd}");
                    Console.ReadKey();
                    Console.WriteLine($"hier in Ream hebben we al langer ruzie met iemand genaamd the masked man. Deze man heeft ons al vaker lastig gevallen in het verleden doormiddel van duistere magie maar gelukkig heeft Ream de hulp van EleOosterium ohja dit is wel handig: {maskedman}");
                    Console.WriteLine("wat je net zag was de Masked Man we hebben doormiddel van onze eigen magie");
                    Console.ReadKey();

                }
                if (kingdom == "")
                {
                    Console.WriteLine("vul iets in");
                    return;
                }
                if (kingdom == "seayar" || kingdom == "Seayar")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Je hebt gekozen voor Seayar");
                    Console.WriteLine("Transporting to Seayar Capital");
                    Console.ReadKey();
                }
                Console.WriteLine(castle2);
                Console.WriteLine($"Welkom in de hoofdstad van {kingdom}");
                Console.WriteLine("[gaurd] De stad word aangevalen snel naar de muur");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(spiders);
                Console.WriteLine("name: Spider clan lvl:1");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HP: ////////// 100%");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine($"{sprite}{name} HP:////////// lvl 1");
                Console.WriteLine("1 - Sword attack 2dmg, 2 - Magic attack 5 dmg + 2 own dmg");
                Console.WriteLine("Kies je aanval");
                string attack = Console.ReadLine();

                if (attack == "1")
                {
                    Console.WriteLine("je gebruikt je zwaard aanval");
                    Console.WriteLine("[console] spinnen clans zijn bestand tegen normale zwaarden gelukkig is die van jouw van speciaal metaal de aanval doet -1 dmg");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(spiders);
                    Console.WriteLine("name: Spider clan lvl:1");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HP: ///////// 90%");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine($"{name} HP:////////// lvl 1");
                }
                Console.ReadKey();
                Console.Clear();
                if (attack == "2")
                {
                    Console.WriteLine("je gebruikt je magie aanval");
                    Console.WriteLine("[console] spinnen clans zijn zwak tegen over magie je doet +2 meer schade in totaal 7 dmg");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(spiders);
                    Console.WriteLine("name: Spider clan lvl:1");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HP: /// 30%");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                }
                Console.WriteLine("de spinnen clan bereid zich voor op de aanval 1/2");
                Console.WriteLine("[zelf] nu is mijn kans");
                Console.WriteLine("");
                Console.WriteLine($"{sprite}{name} HP:////////// lvl 1");
                Console.WriteLine("3 - Ultimate Magic Ultimate decay - 10 dmg kost 90% van je hp ");
                Console.WriteLine("Kies je aanval");
                string attack2 = Console.ReadLine();

                if (attack2 == "3")
                {
                    Console.WriteLine("je roept al je kracht op en roept Bij de naam van Zero Ultimate Decay");
                    Console.WriteLine("[console] Ultimate Magic deze magie soort kost je al je engerie maar zorgt bij een onoplettende tegenstander voor een instant KO");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(spiders);
                    Console.WriteLine("name: Spider clan lvl:1");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HP:  00%");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine($"{name} HP:/ lvl 1");
                    int xp = 10;
                    Console.WriteLine($"{name} heeft {xp} verdient en is hierdoor naar level 2 gegaan ");
                    Console.WriteLine($"Magie aanval is veranderd naar light spell: ark");
                    Console.Clear();
                }

                //seayar story
                if(kingdom == "seayar" || kingdom == "Seayar")
                {
                    Console.WriteLine("een gaurd komt eengerend en vraagt: Vreemdeling gaat alles goed? sinds de verschijning van The masked Mages en the Masked men zijn er steeds meer monsters hier verschenen");
                    Console.WriteLine($"{name}: Alles gaat goed mag ik vragen we de persoon achter u is?");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Dat is de Kapitein van seayar");
                    Console.WriteLine("je hoort een stem in je hoofd val de koning aan val de koning aan. Val je de koning aan Y of N?");
                    string choiceKing = Console.ReadLine();
                    if (choiceKing == "Y" || choiceKing == "y")

                    {

                        Console.WriteLine("je luistert naar de stem en probeert de koning aan te vallen ");
                        Console.WriteLine("de Gaurds pakken je vast en zeggen hoe durf je ze trekken je mee naar de gevangenis en gooien je in een cell");
                        Console.WriteLine($"na 5 dagen hoor je iets vreemds bij je cel je ziet een tovenaar met een masker op die zegt: {name} ik kan je hier uit halen maar hier zit wel een prijs tegen over wat zeg je er vaan y of n? ");
                        string choiceMage = Console.ReadLine();
                        if (choiceMage == "Y" || choiceMage == "y")
                        {
                            Console.WriteLine("Je ontsnapt met de hulp van de masked mage maar hij spreekt een spreuk over je uit en je voeld dat je plots niet meer helder kan denken.");
                            Console.WriteLine("je voelt dat je word geteleporteerd naar Ream waar je samen met andere mobs voor de masked mage vecht alleen gebeurt er iets vreemds steeds als er een battle komt lijkt het alsof het niet werkt zoals eerst je blacked out elke keer dat je vecht ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Je hebt the Masked Mage gejoined en hebt het Hellios einde verdient");
                            Console.WriteLine("door een latere ingeving is er geen fight mer aan het eind dit komt omdat je in een zombie veranderd");
                            Console.WriteLine("Bedankt voor het spelen");
                            Console.ReadKey();
                        }
                        if (choiceMage == "n" || choiceMage == "N")
                        {
                            Console.WriteLine("Je weigert de hulp van de Mage en word later die dag nog onthoofd voor je daden");

                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Goed Gedaan je hebt de meest korte ending gevonden - Neutraal eind");
                            Console.WriteLine("Bedankt voor het spelen");
                            Console.ReadKey();
                        }
                    }
                    if (choiceKing == "n" || choiceKing == "N")
                    {
                            Console.WriteLine($"[Koning Nick]: Jij bent {name} toch? ik heb je broer nog gekend de beste generaal die we ooit hadden, jij was hier toch ook om generaal te worden?");
                            Console.WriteLine($"{name}: Ja dat klopt");
                            Console.WriteLine($"[Koning Nick]: stel me niet teleur {name}");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("[???] Je hebt 5 dagen rust typ zo in wat je doet tijdens deze dagen:");
                            Console.WriteLine($"wat doe je {name}?");
                            string activity = Console.ReadLine();
                            Console.WriteLine($"{name} gaat tijdens de 5 dagen rust {activity} (doen)");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"Generaal {name} snel komt u mee we hebben een masked mage genaamd MYR gevonden");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(maskedman);
                            Console.WriteLine("Name: MYR LVL: 10 hp: //////////////////// 100%");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine(sprite);
                            Console.WriteLine($"name: {name} LVL: 12 hp: /////////////////////");
                            Console.WriteLine("Kies je aanval:");
                            Console.WriteLine("1 - Shinning slash 6 dmg, 2 - Beam Of Ark 10 dmg(takes 1 turn to charge), 3 Ultimate slash 0 dmg??");
                            string choiceBoss = Console.ReadLine();
                            if (choiceBoss == "1")
                            {
                                Console.WriteLine("je gebruikt shining slash en het raakt");

                                Console.WriteLine(maskedman);
                                Console.WriteLine("Name: MYR LVL: 10 hp: ////////////// 14 hp");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("MYR Gebruikt Gods Healing en healt 2 hp");


                                Console.WriteLine(maskedman);
                                Console.WriteLine("Name: MYR LVL: 10 hp: //////////////// 16 hp");

                            }
                            if (choiceBoss == "2")
                            {

                                Console.WriteLine("je gebruikt beam of Ark maar moet 1 beurt wachten normaal gesproken je voelt plots dat je de spreuk nu uit kan voeren MYR neemt 10 dmg");

                                Console.WriteLine(maskedman);
                                Console.WriteLine("Name: MYR LVL: 10 hp: ///////// 10 hp");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("MYR Gebruikt Gods Healing en healt 2 hp");


                                Console.WriteLine(maskedman);
                                Console.WriteLine("Name: MYR LVL: 10 hp: ///////////// 12 hp");
                            }
                            if (choiceBoss == "3")
                            {
                                Console.WriteLine("kleine easteregg dit doet niks maar Myr doet ook niks");
                            }

                            Console.WriteLine("[MYR]Jullie sukkels nu ook gods Healing gebruikt heb ben ik onverslaanbaar en start mijn fase 2");

                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine(maskedman);
                            Console.WriteLine("Name: MYR LVL: 20 hp: ///////////////////////// 100%");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine(sprite);
                            Console.WriteLine($"name: {name} LVL: 12 hp: /////////////////////");
                            Console.WriteLine("Kies je aanval:");
                            Console.WriteLine("1 - Shinning slash 11 dmg, 2 - Beam Of Ark 10 dmg(takes 1 turn to charge), 3 Ultimate slash 0 dmg??");
                            string choiceBoss2 = Console.ReadLine();
                            if (choiceBoss2 == "1")
                            {
                                Console.WriteLine("je gebruikt shining slash en het raakt");

                                Console.WriteLine(maskedman);
                                Console.WriteLine("Name: MYR LVL: 20 hp: ////////////// 14 hp");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("MYR Gebruikt wraak van de goden en dealt 10 damage");
                                Console.WriteLine("");
                                Console.WriteLine($"name: {name} LVL: 12 hp: ///////////");



                            }
                            if (choiceBoss2 == "2")
                            {

                                Console.WriteLine("je gebruikt beam of Ark maar moet 1 beurt wachten normaal gesproken je voelt plots dat je de spreuk nu uit kan voeren MYR neemt 10 dmg");

                                Console.WriteLine(maskedman);
                                Console.WriteLine("Name: MYR LVL: 10 hp: ////////////// 15 hp");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("MYR Gebruikt wraak van de goden en dealt 10 damage");
                                Console.WriteLine("");
                                Console.WriteLine($"name: {name} LVL: 12 hp: ///////////");


                            }
                            if (choiceBoss2 == "3")
                            {
                                Console.WriteLine("kleine easteregg dit doet niks maar Myr doet ook niks");
                            }

                            Console.WriteLine("vlak voor MYR zijn derde fase start zie je een opening en gebruik je met al je macht de Ultimate decay spell MYR kijkt heel geschokt terwijl hij langzaam vergaat tot stof");

                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("Je hebt MYR verslagen goed gedaan je hebt het Elemeros einde bereikt");
                            Console.WriteLine("Bedankt voor het spelen");
                    }

                    }
                       
                    


                    //Ream story
                    if (kingdom == "ream" || kingdom == "Ream")
                    {
                        Console.WriteLine($"[gaurd] {name} kijk eens hier dit is het teken van masked man ik dacht al dat hij hier achterzat.{name} dit klinkt misschien maf maar wij kunnen je wel in ons leger gebruiken wat zeg je er van Join je? ");
                        Console.WriteLine("Y/N");
                        string choice = Console.ReadLine();
                        if (choice == "Y" || choice == "y")
                        {
                            Console.WriteLine($"[{name}] ik doe mee");
                            Console.WriteLine("[gaurd] top er is op het moment zelfs een raid op de basis van de masked man ik weet niet of je zin hebt om hem te gaan verslaan of moet je eerst even rusten in de Taveerne?");
                            Console.WriteLine("Y = Ga met 1 hp het gevecht aan N = bezoek de taveerne eerst en heel je wonden");
                            Console.WriteLine("[Jari] hallo daar ik denk ik stel me even voor ik ben jari diegene die tegen je praate tijdens de spinnen fight");
                            Console.WriteLine("[Jari] voor je iets kiest houd er rekening mee dat Ark steeds meer schade doet als je gewond bent");
                            Console.WriteLine("wat is je keus Y/N");
                            string choice2 = Console.ReadLine();
                            if (choice2 == "y" || choice2 == "Y")
                            {
                                Console.WriteLine($"{name} Ik ga mee f die rust");
                                Console.WriteLine("je loopt mee met de gaurd naar de plek waar het leger staat ze geven je andere spullen");
                                Console.WriteLine("wat kies je?");
                                Console.WriteLine("(1) - Zwaard Van koning Jari: 10 dmg + 3 damage erbij tegen ondooden");
                                Console.WriteLine("(2) - Harnas van de zee: + 10 hp");
                                string choice3 = Console.ReadLine();
                                if (choice3 == "1")
                                {
                                    string specialweapon = "Zwaard van koning jari";
                                    Console.WriteLine($"koos voor {specialweapon}");
                                }
                                if (choice3 == "2")
                                {
                                    string specialweapon = "Harnas van de zee";
                                    Console.WriteLine($"je koos voor {specialweapon}");
                                }

                            }
                            if (choice2 == "n" || choice2 == "N")
                            {
                                Console.WriteLine("Je gaat naar de Taveerne en laat je wonden helen je voelt je zo dat je 12 hp er bij krijgt");

                                Console.WriteLine("je komt aan bij het leger en ze hebben een cadeau voor je");
                                Console.WriteLine($"je krijgt het schild van Aries ");
                                Console.WriteLine("Shild van Aries + 5 def en hp");
                            }
                        Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Je loopt samen met de gaurd richting het slagveld en de gaurd zegt: [Gaurd Aric]Ik zal mezelf even voorstellen ik ben Aric. En ik heb de taak om jou op de hoogt te brengen van wat The Masked Man nu eigenlijk wil bereiken dit verhaal begint diep in onze geschiedenis. Zoals je wel weet is Ream gecreeërd samen met de hulp van Koning Jari en de god EleOosterium. Tijdens deze periode zijn het grootste aantal Grynurianen vermoord of verbannen naar het zeefort. Dit heeft de Grynurianen heel erg geraakt en ze waren woedend genoeg om een deal te maken met de broer van Oosterium die MYROosterium heet.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("[???]Hoor ik daar mijn naam HAHAHA. Hallo door stervelingen ik ben MYROosterium maar zeg maar MYR voor de makkelijkheid. Jij daar nieuweling ik heb een aanbod voor je");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"[{name} Jij dus] wat een aanbod? wat voor aanbod precies?");
                            Console.WriteLine("[MYR] sluit je bij mij aan word een van mijn masked men");
                            Console.WriteLine("[jari]de keus die je hier maakt bepaald wel einde je krijgt wees verzichtig");
                            Console.ReadKey();
                            Console.WriteLine("[MYR] wat zeg je er van Y of N");
                            string choiceEnd = Console.ReadLine();

                            if (choiceEnd == "Y" || choiceEnd == "y")
                            {
                                Console.WriteLine($"{name}: Weet je wat MYR ik sluit me bij je aan");
                                Console.WriteLine("[MYR] Mwahahaha welkom in Hellios knul");
                                Console.Clear();
                                Console.WriteLine("Hellios Einde");
                                Console.WriteLine("Bedankt voor het spelen van PenK Textadventure");
                            }
                            if (choiceEnd == "N" || choiceEnd == "n")
                            {
                                Console.WriteLine($"{name}: Nooit van mijn leven MYR");
                                Console.WriteLine("[MYR]: Verkeerde keuze knul ik raad jullie aan je wapens te pakken");
                                Console.WriteLine("Je voelt je krachten terug komen en je zwaar begint langzaam te schijnen net zoals je harnas beide transformeren in het zwaar van jari en het harnas van Aries als je een schild had ligt die nu gesmolten op de grond");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine(maskedman);
                                Console.WriteLine("Name: MYR LVL: 10 hp: //////////////////// 100%");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine(sprite);
                                Console.WriteLine($"name: {name} LVL: 12 hp: /////////////////////");
                                Console.WriteLine("Kies je aanval:");
                                Console.WriteLine("1 - Shinning slash 6 dmg, 2 - Beam Of Ark 10 dmg(takes 1 turn to charge), 3 Ultimate slash 0 dmg??");
                                string choiceBoss = Console.ReadLine();
                                if (choiceBoss == "1")
                                {
                                    Console.WriteLine("je gebruikt shining slash en het raakt");

                                    Console.WriteLine(maskedman);
                                    Console.WriteLine("Name: MYR LVL: 10 hp: ////////////// 14 hp");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("MYR Gebruikt Gods Healing en healt 2 hp");


                                    Console.WriteLine(maskedman);
                                    Console.WriteLine("Name: MYR LVL: 10 hp: //////////////// 16 hp");

                                }
                                if (choiceBoss == "2")
                                {

                                    Console.WriteLine("je gebruikt beam of Ark maar moet 1 beurt wachten normaal gesproken je voelt plots dat je de spreuk nu uit kan voeren MYR neemt 10 dmg");

                                    Console.WriteLine(maskedman);
                                    Console.WriteLine("Name: MYR LVL: 10 hp: ///////// 10 hp");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("MYR Gebruikt Gods Healing en healt 2 hp");


                                    Console.WriteLine(maskedman);
                                    Console.WriteLine("Name: MYR LVL: 10 hp: ///////////// 12 hp");
                                }
                                if (choiceBoss == "3")
                                {
                                    Console.WriteLine("kleine easteregg dit doet niks maar Myr doet ook niks");
                                }

                                Console.WriteLine("[MYR]Jullie sukkels nu ook gods Healing gebruikt heb ben ik onverslaanbaar en start mijn fase 2");

                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine(maskedman);
                                Console.WriteLine("Name: MYR LVL: 20 hp: ///////////////////////// 100%");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine(sprite);
                                Console.WriteLine($"name: {name} LVL: 12 hp: /////////////////////");
                                Console.WriteLine("Kies je aanval:");
                                Console.WriteLine("1 - Shinning slash 11 dmg, 2 - Beam Of Ark 10 dmg(takes 1 turn to charge), 3 Ultimate slash 0 dmg??");
                                string choiceBoss2 = Console.ReadLine();
                                if (choiceBoss2 == "1")
                                {
                                    Console.WriteLine("je gebruikt shining slash en het raakt");

                                    Console.WriteLine(maskedman);
                                    Console.WriteLine("Name: MYR LVL: 20 hp: ////////////// 14 hp");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("MYR Gebruikt wraak van de goden en dealt 10 damage");
                                    Console.WriteLine("");
                                    Console.WriteLine($"name: {name} LVL: 12 hp: ///////////");



                                }
                                if (choiceBoss2 == "2")
                                {

                                    Console.WriteLine("je gebruikt beam of Ark maar moet 1 beurt wachten normaal gesproken je voelt plots dat je de spreuk nu uit kan voeren MYR neemt 10 dmg");

                                    Console.WriteLine(maskedman);
                                    Console.WriteLine("Name: MYR LVL: 10 hp: ////////////// 15 hp");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("MYR Gebruikt wraak van de goden en dealt 10 damage");
                                    Console.WriteLine("");
                                    Console.WriteLine($"name: {name} LVL: 12 hp: ///////////");


                                }
                                if (choiceBoss2 == "3")
                                {
                                    Console.WriteLine("kleine easteregg dit doet niks maar Myr doet ook niks");
                                }

                                Console.WriteLine("vlak voor MYR zijn derde fase start zie je een opening en gebruik je met al je macht de Ultimate decay spell MYR kijkt heel geschokt terwijl hij langzaam vergaat tot stof");

                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Je hebt MYR verslagen goed gedaan je hebt het Elemeros einde bereikt");
                                Console.WriteLine("Bedankt voor het spelen");
                                 Console.WriteLine("Wil je nog een keer spelen? y or n");
                                string stop = Console.ReadLine();
                            if (stop == "n" || stop == "n")
                            {
                                running = "false";
                            }
                               }
                        }
                    }
            }













        }
    }
}

