using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Data.Sqlite;
using TravelApplication.Models;

namespace TravelApplication.ViewModels
{
    public class TravelAppViewModel
    {
        public static void InitializeDatabase()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=PackagesData.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS PackageTable (Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Code TEXT NULL " +
                    "Destination TEXT NULL" +
                    "Location TEXT NULL" +
                    "Description TEXT NULL" +
                    "HWRank INT NULL" +
                    "FAMRank INT NULL" +
                    "ADVRank INT NULL" +
                    "CRURank INT NULL" +
                    "WEDRank INT NULL" +
                    "SPA INT NULL" +
                    "AMUSEMENT INT NULL" +
                    "HISTORY INT NULL" +
                    "CAMPING INT NULL" +
                    "ENTERTAINMENT INT NULL" +
                    "HealthWell INT NULL" +
                    "Family INT NULL" +
                    "Adventure INT NULL" +
                    "Cruise INT NULL" +
                    "Wedding INT NULL" +
                    "LowPrice INT NULL" +
                    "HighPrice INT NULL" +
                    "DestId INT NULL" +
                    "Link TEXT NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader(); 
            }
            AddEntries(); 
        }
        
        public static void AddEntries()
        {
            //Add initial Health & Wellness Entries
            //Add Pritikin Longevity Center
            AddData("PLCS", "Pritikin Longevity Center + Spa", "Miami, FL", "More than 100, 000 guests worldwide have visited the Pritikin Longevity Center and Spa in Miami, both to prevent and reverse problems such as excess weight, heart disease, diabetes, high blood pressure, high cholesterol and cancer risk factors." +
                " Certified physicians provide each guest with the expert medical attention required for achieving major life changes, while faculty --leaders in the fields of medicine, nutrition, psychology and exercise – lead eye-opening classes focused on " +
                "subjects including dining out, reading labels and calorie density.", 6, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 69,
                499, 1, "http://www.10best.com/awards/travel/best-health-wellness-resort-2016/");
            //Add The Oaks Ojai
            AddData("OAO", "The Oaks at Ojai", "Ojai, CA", "Beautiful Ojai, California sets the stage for wellness for guests of " +
                "The Oaks at Ojai. Casual and welcoming, stays at this all-inclusive wellness retreat include accommodation, 15 " +
                "optional daily fitness activities (think yoga, hiking, pilates, boot camp or belly dancing), three daily meals, " +
                "evening programs and access to the resort's fitness equipment, pool, sauna and hot tubs.", 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0,
                0, 399, 2999, 2, "http://www.10best.com/awards/travel/best-health-wellness-resort-2016/");
            //Add The Ranch Malibu
            AddData("TRM", "The Ranch Malibu", "Malibu, CA", "The Ranch Malibu, an intensive one-week luxury boot camp, eliminates " +
                "decision fatigue with a no-option daily fitness routine featuring group hiking, yoga, weight training and ab work," +
                " all amid spectacular hills above the Pacific Ocean. Healthy meals prepared with fresh, organic ingredients " +
                "exclude processed sugars, alcohol and caffeine.", 5, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 259, 799, 3,
                "http://www.10best.com/awards/travel/best-health-wellness-resort-2016/");
            //Add Red Mountain Resort 
            AddData("RMR", "Red Mountain Resort", "Ivins, Utah", "Fitting for its Utah location, Red Mountain Resort specializes in what it calls " +
                "Adventure Vacations. Surrounded by red rock cliffs and canyons, guests enjoy three healthy meals per day, as well as guided " +
                "activities, like hiking, yoga and fitness classes. Part- and full-day excursions equip guests to actively explore the nearby " +
                "national parks.", 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 299, 999, 4,
                "http://www.10best.com/awards/travel/best-health-wellness-resort-2016/");
            //Add Lake Austin
            AddData("LASR", "Lake Austin Spa Resort", "Austin, TX", "Lake Austin Spa Resort is an award-winning destination spa " +
                "tucked away in the beautiful Texas Hill Country, offering more than 100 treatments alongside luxurious " +
                "accommodations, gourmet meals, a variety of fitness activities and special programs. Many of the " +
                "thoughtfully-appointed guest rooms have been completely updated, and dogs are allowed in the cottages. " +
                "Rates include three gourmet meals daily and a variety of fitness activities and daily events, from yoga and " +
                "paddle boarding to culinary classes and life skills workshops.", 3, 0, 0, 0, 28, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0,
                359, 1299, 5, "http://www.10best.com/awards/travel/best-health-wellness-resort-2016/");
            //Add Hilton Head
            AddData("HHH", "Hilton Head Health", "Hilton Head Island, SC", "Eat right. Move more. Less Stress. Those are the pillars supporting the wellness," +
                " weight loss and longevity programs at Hilton Head Health on South Carolina's beautiful Hilton Head Island." +
                " True Restaurant serves Mediterranean-style menus during all programs, and visitors can unwind between activities" +
                " at the Indigo Spa.Hilton Head Island, SC", 2, 0, 0, 0, 29, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 379, 1399, 6,
                "http://www.10best.com/awards/travel/best-health-wellness-resort-2016/");

            //Add Initial Family Packages
            //Add Orlando-Walt Disney World
            AddData("OWDW", "Orlando-Walt Disney World", "Orlando, FL", "Entire worlds await your family in Orlando. The Wizarding" +
                " World of Harry Potter lures Muggles in droves, but the epic Walt Disney World resort still treats kids of " +
                "all ages to a range of rides and attractions. Parents may find Orlando exhausting, but a Disney trip is a rite" +
                " of passage for kids. ", 0, 1, 0, 0, 4, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 199, 1450, 7,
                "https://travel.usnews.com/rankings/best-family-vacations/");
            //Add DisneyLand
            AddData("ADC", "Anaheim Disneyland", "Malibu, CA", "This area of Southern California isn't home to as many amusement " +
                "parks as its Florida counterpart, but the original Disney resort is still fun for the whole family. Plus," +
                " after a day at the theme park it's just a short drive to the beach. If you plan to travel in the summer, " +
                "make sure to book your hotel early to secure the best rates.", 0, 2, 0, 0, 5, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 150, 950, 8,
                 "https://travel.usnews.com/rankings/best-family-vacations/");
            //Add Branson
            AddData("BMS", "Branson", "Branson, MS", "Families travel to this charming Missouri city for its affordability and " +
                "quirky, themed attractions. Families can transport themselves back to the 19th century at the Silver Dollar " +
                "City amusement park or tour a life-size replica of the Titanic before cooling off with a dip in Table Rock Lake.",
                0, 9, 0, 0, 15, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 70, 599, 9,
                "https://travel.usnews.com/rankings/best-family-vacations/");
            //Add Sydney Australia
            AddData("SAUS", "Sydney", "Sydney, AUS", "While the city's most popular sights may not appeal to the entire family, " +
                "its kid-friendly attractions will. Darling Harbour alone boasts the Sydney Aquarium and the Australian" +
                " National Maritime Museum. When temperatures rise, hit Coogee and Bondi beaches. Travel during the shoulder" +
                " seasons (fall and spring) to avoid the summer crowds. ", 0, 5, 0, 0, 6, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 325, 2500,
                10, "https://travel.usnews.com/rankings/best-family-vacations/");
            //Add SanDiego
            AddData("SDC", "SanDiego", "SanDiego, CA", "Year-round pleasant temperatures and miles of beaches are just part of the reason" +
                " families love to vacation in San Diego. The city offers an abundance of outdoor activities and attractions like " +
                "SeaWorld and the San Diego Zoo, so both kids and adults will be entertained.", 0, 3, 0, 0, 16, 0, 1, 0, 0, 1, 0, 1,
                0, 0, 1, 125, 899, 11, "https://travel.usnews.com/rankings/best-family-vacations/");
            //Add Grand Canyon
            AddData("GCA", "Grand Canyon", "Grand Canyon, AZ", "The beauty of the Grand Canyon should not be understated, and " +
                "neither should the many ways to enjoy it. Whether you and the kids raft down the Colorado River or camp near " +
                "Havasu Falls, your family will never forget the adventures and memories made here", 0, 4, 12, 0, 17, 0, 0, 1, 1,
                0, 0, 1, 1, 0, 1, 89, 650, 12, "https://travel.usnews.com/rankings/best-family-vacations/");
            //Add Yellowstone
            AddData("YNPW", "Yellowstone National Park", "Yellowstone, WY", "There's no replacement for family bonding in a tent " +
                "or under the stars. When you're not roasting marshmallows around the fire, your family can spend time at famous " +
                "sights like the Grand Prismatic Spring and Old Faithful.", 0, 6, 13, 0, 18, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 59, 600,
                13, "https://travel.usnews.com/rankings/best-family-vacations/");
            //Add Washington D.C.
            AddData("WDC", "Washington, D.C.", "Washington, D.C. ", "Families looking to add an educational bent to their vacation" +
                " should seek out Washington, D.C., for its countless ties to U.S. history. Kids and adults can both enjoy a visit" +
                " to the Lincoln Memorial or an afternoon spent at the National Zoo. Plus, most major attractions are free to " +
                "explore and there are a wealth of hotels to choose from.", 0, 7, 0, 0, 19, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 100, 752,
                14, "https://travel.usnews.com/rankings/best-family-vacations/");
            //Add Maui
            AddData("MHI", "Maui", "Maui, HI", "This Hawaiian island offers a little something for each member of the family." +
                " Nature enthusiasts can snap photos of the beautiful landscape along the road to Hana, sports lovers can spend " +
                "the day on the golf course and culture hounds can participate in a traditional luau. You won't regret splurging " +
                "on a stay in an oceanfront hotel suite.", 0, 8, 0, 0, 3, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 320, 2520,
                15, "https://travel.usnews.com/rankings/best-family-vacations/");

            //Add Initial Adventure Packages to Table
            //Add Philipines
            AddData("SFNSP", "Sailing for non-sailors in the Philippines", "Philippines", "A chance to hoist the main sail and set" +
                " out to sea on an adventure designed to turn landlubbers into salty seadogs, this trip involves sailing a " +
                "skippered paraw trimaran around uninhabited islands near Borocay in the Philippines. Intrepid travelers are given " +
                "daily challenges to complete, with the aim of learning seagoing skills and meeting local people. This jaunt is the " +
                "ultimate sailing trip for non-sailors.", 0, 0, 1, 0, 20, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 500, 3500,
                16, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Mongolia
            AddData("MDHR", "Mongol Derby -- the toughest horse race in the world", "Mongolia", "A 1,000-kilometer course through " +
                "some of the most remote country in the world, the Mongol Derby offers a challenge for those who have plenty of " +
                "vacation and a serious dose of gumption to boot. Recreating Genghis Khan's horse messenger system, experienced " +
                "riders will travel up to 160 kilometers a day, herding horses between 25 traditional morin urtuus (horse stations)." +
                " A huge support team of medics and veterinarians is on hand throughout.", 0, 0, 5, 0, 21, 0, 0, 0, 1, 0, 0, 0, 1, 0,
                1, 550, 3850, 17, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Shark Swimming
            AddData("SWSM", "Swimming with whale sharks in the Maldives", "Maldive's South Ari Atoll", "Whale sharks are abundant" +
                " just off the Maldives' South Ari Atoll. Local experts lead expeditions from the Mirihi Island Resort on a 55-foot" +
                " wooden yacht, with the opportunity to strap on a mask and snorkel and swim alongside the largest fish in the " +
                "world. These gentle giants are often surrounded by other fish and sea creatures looking for protection from " +
                "predators, making entering the water with them a truly stunning spectacle.", 0, 0, 8, 0, 22, 0, 0, 0, 0, 0, 0, 0,
                1, 0, 1, 450, 3150, 18, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Cycling Mount Fuji
            AddData("CMFK", "Cycling from Mount Fuji to Kyoto", "Mount Fuji, Japan", "Rather than zipping straight to Kyoto from Tokyo " +
                "in a matter of hours on the shinkansen high-speed train, intrepid travelers can saddle up and take the slow road" +
                " on this 12-day trip. Following an e-bike tour of Tokyo, things take a more strenuous turn on a ride around Fuji " +
                "Five Lakes, with Japan's most iconic mountain as a backdrop.The route also takes in traditional villages near" +
                " Lake Biwa, before ending in the ancient capital of Kyoto, with its abundance of peaceful temples and traditional" +
                " ryokan, or inns.", 0, 0, 9, 0, 23, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 600, 4200,
                19, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Piranha Fishing in Amazon
            AddData("KPFA", "Kayaking and piranha fishing in the distant Amazon", "Columbia, Peru, & Brazil", "Traveling in a dugout canoe through" +
                " some of the most remote parts of the Amazon in Colombia, Peru and Brazil, this trip is not for the faint of" +
                " heart. Bedding down in the middle of the jungle, there's the opportunity to fish for piranhas, meet indigenous " +
                "tribes and trek through the forest at night, when the wildlife is at its most vociferous.", 0, 0, 6, 0, 0, 0, 0, 1,
                1, 0, 0, 0, 1, 0, 0, 1000, 6000, 20, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Sri Lanka
            AddData("TTCSL", "A 1,000km tuk-tuk challenge across Sri Lanka", "Sri Lanka", "On this 10-day trip teams of travelers " +
                "are challenged to find local hotspots and glean information from locals, all in the name of friendly competition. " +
                "Covering a massive 1,000 kilometers in notoriously unreliable tuk-tuks makes things more interesting.Support teams " +
                "are on hand throughout, while there's a chance of encountering local wildlife, including elephants. A portion of " +
                "the trip's cost is donated to local charities.", 0, 0, 11, 0, 24, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 999, 5999,
                21, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Ice Run
            AddData("IRMB", "The Ice Run: Motor biking across frozen Lake Baikal", "Lake Baikal, Russia", "With a Russian motorbike" +
                " and sidecar for transport, the Ice Run is a dream trip for adventure fiends. Starting and finishing in Irkutsk," +
                " this challenging ride follows remote forest tracks and long routes over the snowy, open steppe, before taking" +
                " to the icy expanse of Lake Baikal, the deepest lake in the world. 4x4 support vehicles are on hand, as is GPS to " +
                "help find essential stops for food and fuel. There are classes on ice riding and motorcycle maintenance before " +
                "the trip sets out.", 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1599, 7999,
                22, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Glacier Walking
            AddData("GWN", "Glacier walking in Norway", "Norway", "Adventure company Flash Pack's singles trips put together " +
                "like-minded individuals on exciting jaunts, with the chance to meet fellow travelers before hitting the road." +
                "Its Norway adventure requires some stamina, with guests strapping on crampons and wielding ice axes for a hike " +
                "across the vast Haugabreen glacier. Nerves settled, there's then the chance to go sea kayaking among towering " +
                "fjords and hike through the spectacular Jostedalsbreen National Park.", 0, 0, 10, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1,
                0, 0, 899, 4500, 23, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Cave Diving
            AddData("CDT", "Cave diving in Tuscany", "Tuscany, Italy", "A luxury Tuscan villa might not seem the most obvious place" +
                " for adrenaline junkies to find their fix. But then Grotta Giusti isn't your average luxury Tuscan villa. " +
                "Beneath its stunning rooms is an underground thermal hot spring lake, where guests can try cave diving. After " +
                "clambering down a cleft in the rock, instructors lead adventurers through crystal-clear water, past stalagmites " +
                "and stalactites via a network of labyrinthine tunnels to a series of large caves.", 0, 0, 3, 0, 25, 0, 0, 1, 0, 0,
                0, 0, 1, 0, 1, 1999, 9599, 24, "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Rhino Trekking
            AddData("RTN", "Rhino trekking in Namibia ", "Namibia, Africa", "Setting off before sunrise in 4x4s from Namibia's " +
                "remote Desert Rhino Camp, this trek takes searching for endangered rhinos to another level. With experts from " +
                "Save The Rhinos, travelers can join trackers on foot to get up close to these majestic creatures once they've " +
                "been located.", 0, 0, 4, 0, 26, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 2500, 9000, 25,
                "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");
            //Add Heli-Exploring
            AddData("HECR", "Heli-exploring the Canadian Rockies ", "Canada", "A week-long adventure in the Canadian Rockies is " +
                "likely to be many outdoor types' idea of a dream vacation. Throw in a private helicopter to allow access to some " +
                "of the range's most remote passes, meadows and peaks and it's hard to imagine a better break. After two days" +
                " spent acclimatizing in Banff National Park, the chopper takes travelers into the high country of the Purcell " +
                "Mountains for a 72-hour adventure, with experts leading hikes across snow fields and valleys.", 0, 0, 2, 0, 27, 0,
                0, 1, 1, 0, 0, 0, 1, 0, 1, 2550, 9500, 26,
                "https://www.cnn.com/travel/article/best-adventure-vacations-2018/index.html");

            //Add Initial Cruise Packages
            //Add Regent Seven Seas
            AddData("RSSC", "Regent Seven Seas Cruises - Regent", "Mediteranean Cruise", "Regent Seven Seas is arguably the most " +
                "inclusive of the biggest luxury brands. Its fares include all-suite accommodations (98 percent come with balconies)," +
                " meals in main and specialty dining venues, pre- and post-cruise tours and hotel stays, gratuities, shore" +
                " excursions and beverages from liquor to sodas (in your suite, at dinner or in the ships' public areas). The" +
                " ships are on the larger size for luxury, carrying 490 to 750 passengers each -- small enough to create a social" +
                " onboard atmosphere without the crowds of a big ship, but large enough to offer spacious cabins (the smallest is " +
                "301 square feet) and enough dining and entertainment venues to prevent boredom. Luxury touches abound, whether it" +
                " be a butler in your penthouse suite or exclusive premium bath amenities designed by the L'Occitane line. The" +
                " 750-passenger Seven Seas Explorer has over-the-top suites and the highest staff-to-passenger ratios in the " +
                "industry. Wherever in the world you choose to sail, you will be truly pampered. ", 0, 0, 0, 6, 7, 1, 0, 0, 0, 1,
                0, 0, 0, 1, 1, 2000, 5025, 27, "https://www.rssc.com/");
            //Add  Laos Cruise
            AddData("LCMC", "Laos Cruise - Avalon Waterways", "Laos Mekong, Cambodia/Thailand", "This relatively small country is the next" +
                " big thing in Asia river cruising. Touching Vietnam, Cambodia, Thailand, Myanmar (Burma) and the southern tip of " +
                "China, Laos is at the epicenter of Southeast Asia. Its capital, Vientiane, is located along the Mekong River and " +
                "showcases French colonial architecture alongside revered Buddhist temples and relics. Most riverboats call nearly " +
                "200 miles north in Luang Prabang, a UNESCO World Heritage Site, which offers natural caves, waterfalls and shrines." +
                "Pandaw River Cruises offers itineraries in Laos and on the Upper Mekong, with 10-night sailings upstream or" +
                " downstream. The line will add Sabei Pandaw, its third ship in the region, in November 2018. Avalon Waterways " +
                "also offers Cambodia/Vietnam cruises that end in Luang Prabang.", 0, 0, 0, 1, 8, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1,
                4530, 9030, 28, "https://www.pandaw.com/expeditions/laos-mekong/");
            //Add  Glacier Bay
            AddData("GBAC", "Glacier Bay - Carnival Cruise Lines", "Glacier Bay, Alaska", "A destination eons in the making, " +
                "Glacier Bay’s pristine landscape makes it one of the top spots on an Alaska traveler’s must-see list. Your Glacier" +
                " Bay cruise takes you through this protected national park spread across 3.2 million acres of southeast Alaska… " +
                "home to 15 active glaciers, countless seabirds, otters and humpback whales. And a Carnival Alaska cruise is the " +
                "best way to get right in the middle of it! Your experience begins with complimentary maps to help get the most " +
                "out of the day’s sightseeing. Then we invite local park rangers to board the ship, narrate your journey and point" +
                " out the best sights along the way, throughout the day.", 0, 0, 0, 7, 9, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1510, 6410,
                29, "https://www.carnival.com/cruise-to/alaska-cruises/glacier-bay-cruises.aspx");
            //Add  Mystery Island
            AddData("MIVC", "Mystery Island - Princess Cruises", "Mystery Island, Vanuatu", "This tiny, uninhabited inlet," +
                " originally named Inyeug, is located at the southernmost end of the Vanuatu archipelago approximately half a " +
                "mile from the mainland, Aneityum Island. Used during World War II as an airstrip for the allied forces, it was " +
                "dubbed Mystery Island because its location prevented the Japanese from seeing it from the water, making the " +
                "appearance of allied planes a mystery. With its white sand beaches, swaying palm trees and spectacularly clear" +
                " waters, Mystery Island still holds the allure of a secret oasis. For the adventurous, aquatic activities," +
                " snorkeling, kayaking ,stand-up paddleboards, and a glass bottom boat offer various way to enjoy the surrounding" +
                " coral reef.", 0, 0, 0, 8, 11, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1,
                1045, 7065, 30, "https://www.princess.com/excursion/exlistfordestination.do?portid=MY2&exType=S&t=I");
            //Add  St. Petersburg Cruise
            AddData("SPRC", "St. Petersburg - Norwegian Cruise Line", "St. Petersburg, Russia", "Founded by the Russian Tsar," +
                " Peter the Great, St. Petersburg has for centuries been the cultural center of Russia, with its spectacular " +
                "architecture, Tchaikovsky operas and the famous Kirov ballet. It has undergone many changes over the decades," +
                " but “The Venice of the North” remains a dazzling cruise destination, a Russian city with a European flair, a " +
                "city with more than 200 museums, and one of the largest English gardens in Europe.", 0, 0, 0, 2, 10, 1, 0, 1, 0, 1,
                0, 0, 0, 1, 1, 1675, 8540, 31, "https://www.ncl.com/port-of-call/cruises-to-st-petersburg");
            //Add  St. Maarten Cruise
            AddData("SMNC", "St. Maarten - Carnival Cruise", "St. Maarten, NA", "Explore two colorful nations on one exotic island " +
                "on one vacation. Split down the middle centuries ago by two European powers, this 37-mile isle offers cosmopolitan" +
                " culture, international shopping, and world-class cuisine with a laid-back Caribbean atmosphere. Cruise to " +
                "St. Maarten and you’ll find the island’s natural attributes are equally fine: the rugged coastline shelters " +
                "silky crescents of sand framed by green undulating hills. Enjoy the laidback vibe of the beach or put on your " +
                "hiking shoes and explore ruins of historic forts. One thing’s for sure, when you cruise to St. Maarten you will" +
                " come home with amazing memories that will last a lifetime.", 0, 9, 0, 10, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1,
                895, 5365, 32, "https://www.carnival.com/cruise-to/caribbean-cruises/st-maarten-cruises.aspx");
            //Add Bonaire
            AddData("BKC", "Bonaire - Royal Carribean Cruise", "Bonaire, Kralenduk", "You'll definitely want to see Sorobon Beach, " +
                "on the east side of Bonaire located within a large protected bay. Enjoy sunbathing or windsurfing, which has " +
                "become quite popular in Sorobon Beach thanks to the warm shallow water, steady trade winds and abundance of " +
                "sunshine. Sorobon Beach has hosted both local and international windsurfing competitions. Also a must-see are " +
                "Bonaire's famous pink flamingos which, in mating season, number in the 15,000s.", 0, 0, 0, 9, 12, 1, 0, 0, 0, 1,
                0, 0, 0, 1, 1, 1075, 8310, 33, "http://www.royalcaribbean.com/findacruise/ports/group/home.do?portCode=BON");
            //Add Cozumel Mexico Cruise
            AddData("CMC", "Cozumel - Princess Cruises ", "Cozumel, Mexico", "Mayan myth claims that Cozumel was home to the gods." +
                " Truly Cozumel is a place fit for the gods, with its dazzling white-sand beaches, ruined Mayan temples, exotic " +
                "jungle wildlife, and crystalline waters teeming with tropical fish. Just offshore lay Palancar Reef, considered " +
                "one of the most spectacular coral formations in all the Caribbean. Of course, the gods weren't the only" +
                " individuals attracted to this terrestrial paradise: during its long and colorful history, Cozumel has been home " +
                "to pirates, buccaneers, and freebooters, including Sir Henry Morgan and Jean Lafitte. Today's traveler will " +
                "discover the same ravishing beauty and relaxation that entertained gods and pirates alike.", 0, 0, 0, 3, 2, 1, 0,
                1, 0, 1, 0, 0, 0, 1, 1, 435, 3475, 34,
                "https://www.princess.com/excursion/exlistfordestination.do?portid=CZM&exType=S&t=C");
            //Add Amsterdam Cruise
            AddData("AMHC", "Amsterdam - Royal Carribean Cruise Line", "Amsterdam, Holland", "Life in Amsterdam is centered on its " +
                "many canals. So the best way to see the city is aboard a glass-topped canal boat, gliding through the town center." +
                " Discover the elegant merchant mansions and rows of waterside warehouses, which once housed the riches brought " +
                "from the Far East. Look for the 17th-century Skinny Bridge and Amsterdam's narrowest house as you make your way " +
                "past beautiful old churches to the Anne Frank House. Journey by the Jordaan, the old French Quarter that is now a" +
                " popular artists' haunt with a wide assortment of cafés, antique shops, boutiques and galleries. Visit the " +
                "world's largest flower auction in the city of Aalsmeer, and more.", 0, 0, 0, 5, 13, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1,
                1960, 7690, 35, "http://www.royalcaribbean.com/findacruise/ports/group/home.do?portCode=AMS");
            //Add Venice Cruise
            AddData("VIC", "Venice - Princess Cruise Lines", "Venice, Italy", "Rising from the waters of the Laguna Veneta, " +
                "Venice has long - and rightly - been regarded as one of the world's most beautiful cities. Napoleon, who had an" +
                " eye for acquisitions, once described St. Mark's Square as the finest drawing room in Europe. Certainly, no " +
                "other site can quite match its superb campanile, Doge's Palace and recumbent lions. Just over two miles in length," +
                " the Grand Canal is lined with stunning buildings that reflect the city's unique heritage. Cruise through its " +
                "winding canals on a gondola or watch the bronze Moors on the clock tower strike the passing hours as they have " +
                "for 500 years - Venice is an unparalleled experience. The city began life as a refuge from barbarian invasions. " +
                "By the Crusades, Venice's dominion extended throughout the Adriatic and Mediterranean. The winged lion - symbol " +
                "of St. Mark - flew over palaces and fortresses from Gibraltar to the Black Sea. ", 0, 0, 0, 4, 14, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1,
                1960, 7690, 36, "https://www.princess.com/excursion/exlistfordestination.do?portid=VCE&exType=S&t=E");
        }

        public static void AddData(string value1, string value2, string value3, string value4, int value5, int value6, int value7,
            int value8, int value9, int value10, int value11, int value12, int value13, int value14, int value15, int value16, int value17,
            int value18, int value19, int value20, int value21, int value22, string value23)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=PackagesData.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand("INSERT INTO PackageTable (NULL, Code, Destination, Location, Description, HWRank, FAMRank, " +
                    "ADVRank, CRURank, WEDRank, SPA, AMUSEMENT, HISTORY, CAMPING, ENTERTAINMENT, " +
                    "HealthWell, Family, Adventure, Cruise, Wedding, LowPrice, HighPrice, DestId, Link) " +
                    "VALUES (NULL, @value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9, @value10, @value11, " +
                    "@value12, @value13, @value14, @value15, @value16, @value17, @value18, @value19, @value20, @value21, @value22, " +
                    "@value23)");

                insertCommand.Parameters.AddWithValue("@value1", value1);
                insertCommand.Parameters.AddWithValue("@value2", value2);
                insertCommand.Parameters.AddWithValue("@value3", value3);
                insertCommand.Parameters.AddWithValue("@value4", value4);
                insertCommand.Parameters.AddWithValue("@value5", value5);
                insertCommand.Parameters.AddWithValue("@value6", value6);
                insertCommand.Parameters.AddWithValue("@value7", value7);
                insertCommand.Parameters.AddWithValue("@value8", value8);
                insertCommand.Parameters.AddWithValue("@value9", value9);
                insertCommand.Parameters.AddWithValue("@value10", value10);
                insertCommand.Parameters.AddWithValue("@value11", value11);
                insertCommand.Parameters.AddWithValue("@value12", value12);
                insertCommand.Parameters.AddWithValue("@value13", value13);
                insertCommand.Parameters.AddWithValue("@value14", value14);
                insertCommand.Parameters.AddWithValue("@value15", value15);
                insertCommand.Parameters.AddWithValue("@value16", value16);
                insertCommand.Parameters.AddWithValue("@value17", value17);
                insertCommand.Parameters.AddWithValue("@value18", value18);
                insertCommand.Parameters.AddWithValue("@value19", value19);
                insertCommand.Parameters.AddWithValue("@value20", value20);
                insertCommand.Parameters.AddWithValue("@value21", value21);
                insertCommand.Parameters.AddWithValue("@value22", value22);
                insertCommand.Parameters.AddWithValue("@value23", value23);
                var sqliteConnection1 = insertCommand.Connection;
                sqliteConnection1.Open();
                var trans = sqliteConnection1.BeginTransaction();

                try
                {
                    var retval = insertCommand.ExecuteNonQuery();
                    if (retval == 1)
                    {
                        Console.WriteLine("Row Inserted!");
                    }
                    else
                    {
                        Console.WriteLine("Row NOT Inserted!");
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
                finally
                {
                    trans.Commit();
                    insertCommand.Dispose();
                    sqliteConnection1.Close();
                    db.Close();
                }
            }
        }

        //Create a sortable observable collection to hold the TravelPackage data 
        public static ObservableCollection<TravelPack> GetData()
        {
            var travelPackages = new ObservableCollection<TravelPack>();
            const string GetTravelQuery = "SELECT * FROM PackageTable";
            try
            {
                using (SqliteConnection db = new SqliteConnection("Filename=PackagesData.db"))
                {
                    db.Open();
                    if (db.State == System.Data.ConnectionState.Open)
                    {
                        using (SqliteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = GetTravelQuery;
                            using (SqliteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {

                                    var package = new TravelPack();
                                    package.dcode = reader.GetString(1);
                                    package.dest = reader.GetString(2);
                                    package.locate = reader.GetString(3);
                                    package.descript = reader.GetString(4);
                                    package.HW = reader.GetInt32(5);
                                    package.FAM = reader.GetInt32(6);
                                    package.ADV = reader.GetInt32(7);
                                    package.CRU = reader.GetInt32(8);
                                    package.WED = reader.GetInt32(9);
                                    package.SPA = reader.GetInt32(10);
                                    package.AMUSE = reader.GetInt32(11);
                                    package.HISTORIC = reader.GetInt32(12);
                                    package.CAMP = reader.GetInt32(13);
                                    package.ENTERTAIN = reader.GetInt32(14);
                                    package.hw = reader.GetInt32(15);
                                    package.fam = reader.GetInt32(16);
                                    package.adv = reader.GetInt32(17);
                                    package.cru = reader.GetInt32(18);
                                    package.wed = reader.GetInt32(19);
                                    package.priceLow = reader.GetInt32(20);
                                    package.priceHigh = reader.GetInt32(21);
                                    package.DESTId = reader.GetInt32(22);
                                    package.refLink = reader.GetString(23);
                                    travelPackages.Add(package);

                                }
                            }
                        }
                        db.Close();
                    }
                }
                return travelPackages;
            }
            catch
            {
                return null;
            }
        }

        //Create a sortable observable collection to hold the Health & Wellness TravelPackage data 
        public static ObservableCollection<HealthTravel> GetHealthData()
        {
            var healthPackages = new ObservableCollection<HealthTravel>();
            const string GetHealthQuery = "SELECT * FROM PackageTable WHERE HealthWell=1";
            try
            {
                using (SqliteConnection db = new SqliteConnection("Filename=PackagesData.db"))
                {
                    db.Open();
                    if (db.State == System.Data.ConnectionState.Open)
                    {
                        using (SqliteCommand cmd = db.CreateCommand())
                        {
                            cmd.CommandText = GetHealthQuery;
                            using (SqliteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {

                                    var health = new HealthTravel();
                                    health.dcode = reader.GetString(1);
                                    health.dest = reader.GetString(2);
                                    health.locate = reader.GetString(3);
                                    health.descript = reader.GetString(4);
                                    health.rank = reader.GetInt32(5);
                                    health.SPA = reader.GetInt32(10);
                                    health.AMUSE = reader.GetInt32(11);
                                    health.HISTORIC = reader.GetInt32(12);
                                    health.CAMP = reader.GetInt32(13);
                                    health.ENTERTAIN = reader.GetInt32(14);
                                    health.cat = reader.GetInt32(15);
                                    health.priceLow = reader.GetInt32(20);
                                    health.priceHigh = reader.GetInt32(21);
                                    health.destid = reader.GetInt32(22);
                                    health.refLink = reader.GetString(23);
                                    healthPackages.Add(health);
                                }
                            }
                        }
                        db.Close();
                    }
                }
                return healthPackages;
            }
            catch
            {
                return null;
            }
        }
    }
}
