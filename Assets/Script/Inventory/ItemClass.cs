using UnityEngine;

public class ItemClass : MonoBehaviour
{   /*
    //Assembling Machine Icons//
    static public Texture2D AssemblingMachine1Icon;
    static public Texture2D AssemblingMachine2Icon;
    static public Texture2D AssemblingMachine3Icon;
    static public Texture2D AssemblingMachine4Icon;
    static public Texture2D AssemblingMachine5Icon;
    
    //SciencePack Icon//
    static public Texture2D SciencePack1Icon;
    static public Texture2D SciencePack2Icon;
    static public Texture2D SciencePack3Icon;
    static public Texture2D SciencePack4Icon;
    static public Texture2D SciencePack5Icon;
    static public Texture2D SciencePack6Icon;
    static public Texture2D SciencePack7Icon;
    static public Texture2D SciencePack8Icon;
    static public Texture2D SciencePack9Icon;
    static public Texture2D SciencePack10Icon;

    //Belts, Loaders, Inserter Icon//
    static public Texture2D TransportBeltIcon;
    static public Texture2D LoaderIcon;
    static public Texture2D InserterIcon;

    //Coin Icon//
    static public Texture2D CopperCoinIcon;
    static public Texture2D IronCoinIcon;
    static public Texture2D PlatinumCoinIcon;
    static public Texture2D GoldCoinIcon;

    //Misc Icon//
    static public Texture2D MiningDrillIcon;
    static public Texture2D ElectricPoleIcon;
    static public Texture2D BulletIcon;
    static public Texture2D PistolIcon;
    static public Texture2D MagazineIcon;

    //Stone Icon//
    static public Texture2D StoneIcon;
    static public Texture2D CrushedStoneIcon;

    //Iron Icon//
    static public Texture2D RoughIronOreIcon;
    static public Texture2D CrushedIronOreIcon;
    static public Texture2D IronCrystalIcon;
    static public Texture2D PurifiedIronOreIcon;
    static public Texture2D PureIronOreIcon;

    //Copper Icon//
    static public Texture2D RoughCopperOreIcon;
    static public Texture2D CrushedCopperOreIcon;
    static public Texture2D CopperCrystalIcon;
    static public Texture2D PurifiedCopperOreIcon;
    static public Texture2D PureCopperOreIcon;

    //Gold Icon//
    static public Texture2D RoughGoldOreIcon;
    static public Texture2D CrushedGoldOreIcon;
    static public Texture2D GoldCrystalIcon;
    static public Texture2D PurifiedGoldOreIcon;
    static public Texture2D PureGoldOreIcon;

    //Platinum Icon//
    static public Texture2D RoughPlatinumOreIcon;
    static public Texture2D CrushedPlatinumOreIcon;
    static public Texture2D PlatinumCrystalIcon;
    static public Texture2D PurifiedPlatinumOreIcon;
    static public Texture2D PurePlatinumOreIcon;

    //Uranium Icon//
    static public Texture2D RoughUraniumOreIcon;
    static public Texture2D CrushedUraniumOreIcon;
    static public Texture2D UraniumCrystalIcon;
    static public Texture2D PurifiedUraniumOreIcon;
    static public Texture2D PureUraniumOreIcon;

    //Silver Icon//
    static public Texture2D RoughSilverOreIcon;
    static public Texture2D CrushedSilverOreIcon;
    static public Texture2D SilverCrystalIcon;
    static public Texture2D PurifieSilverOreIcon;
    static public Texture2D PureSilverOreIcon;

    //Lead Icon//
    static public Texture2D RoughLeadOreIcon;
    static public Texture2D CrushedLeadOreIcon;
    static public Texture2D LeadCrystalIcon;
    static public Texture2D PurifiedLeadOreIcon;
    static public Texture2D PureLeadOreIcon;

    //Tin Icon//
    static public Texture2D RoughTinOreIcon;
    static public Texture2D CrushedTinOreIcon;
    static public Texture2D TinCrystalIcon;
    static public Texture2D PurifiedTinOreIcon;
    static public Texture2D PureTinOreIcon;

    //Zinc Icon//
    static public Texture2D RoughZincOreIcon;
    static public Texture2D CrushedZincOreIcon;
    static public Texture2D ZincCrystalIcon;
    static public Texture2D PurifiedZincOreIcon;
    static public Texture2D PureZincOreIcon;

    //Aluminium Icon//
    static public Texture2D RoughAluminiumOreIcon;
    static public Texture2D CrushedAluminiumOreIcon;
    static public Texture2D AluminiumCrystalIcon;
    static public Texture2D PurifiedAluminiumOreIcon;
    static public Texture2D PureAluminiumOreIcon;

    //Magnesium Icon//
    static public Texture2D RoughMagnesiumOreIcon;
    static public Texture2D CrushedMagnesiumOreIcon;
    static public Texture2D MagnesiumCrystalIcon;
    static public Texture2D PurifiedMagnesiumOreIcon;
    static public Texture2D PureMagnesiumOreIcon;

    //Liquid//
    static public Texture2D SulfuricAcidIcon;

    //Gas//
    static public Texture2D OxygenIcon;
    

    //Assembling Machine Icons//
    public ItemCreatorClass AssemblingMachine1 = new ItemCreatorClass(0, "Assembling Machine 1", AssemblingMachine1Icon, "Crafts items that need up to 1 ingredients." +
                                                                                                                         "Crafting Speed: 0.5" + 
                                                                                                                         "Energy Consumption: 50 kW" + 
                                                                                                                         "Drain: 5 kW" + 
                                                                                                                         "Pollution: 1" + 
                                                                                                                         "Module Slot: 0 slot");

    public ItemCreatorClass AssemblingMachine2 = new ItemCreatorClass(1, "Assembling Machine 2", AssemblingMachine2Icon, "Crafts items that need up to 2 ingredients." +
                                                                                                                         "Crafting Speed: 0.75" + 
                                                                                                                         "Energy Consumption: 100 kW" + 
                                                                                                                         "Drain: 8 kW" + 
                                                                                                                         "Pollution: 2" + 
                                                                                                                         "Module Slot: 1 slot");

    public ItemCreatorClass AssemblingMachine3 = new ItemCreatorClass(2, "Assembling Machine 3", AssemblingMachine3Icon, "Crafts items that need up to 3 ingredients." +
                                                                                                                         "Crafting Speed: 1" + 
                                                                                                                         "Energy Consumption: 150 kW" + 
                                                                                                                         "Drain: 10 kW" + 
                                                                                                                         "Pollution: 3" + 
                                                                                                                         "Module Slot: 2 slot");

    public ItemCreatorClass AssemblingMachine4 = new ItemCreatorClass(3, "Assembling Machine 4", AssemblingMachine4Icon, "Crafts items that need up to 4 ingredients." +
                                                                                                                         "Crafting Speed: 1.5" + 
                                                                                                                         "Energy Consumption: 250 kW" + 
                                                                                                                         "Drain: 15 kW" + 
                                                                                                                         "Pollution: 5" + 
                                                                                                                         "Module Slot: 3 slot");

    public ItemCreatorClass AssemblingMachine5 = new ItemCreatorClass(4, "Assembling Machine 5", AssemblingMachine5Icon, "Able to craft any item" +
                                                                                                                         "Crafting Speed: 2" + 
                                                                                                                         "Energy Consumption: 500 kW" + 
                                                                                                                         "Drain: 20 kW" + 
                                                                                                                         "Pollution: 8" + 
                                                                                                                         "Module Slot: 5 slot");
    //SciencePack Icon//
    public ItemCreatorClass SciencePack1Item = new ItemCreatorClass(5, "Science Pack 1", SciencePack1Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack2Item = new ItemCreatorClass(6, "Science Pack 2", SciencePack2Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack3Item = new ItemCreatorClass(7, "Science Pack 3", SciencePack3Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack4Item = new ItemCreatorClass(8, "Science Pack 4", SciencePack4Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack5Item = new ItemCreatorClass(9, "Science Pack 5", SciencePack5Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack6Item = new ItemCreatorClass(10, "Science Pack 6", SciencePack6Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack7Item = new ItemCreatorClass(11, "Science Pack 7", SciencePack7Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack8Item = new ItemCreatorClass(12, "Science Pack 8", SciencePack8Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack9Item = new ItemCreatorClass(13, "Science Pack 9", SciencePack9Icon, "Used By 'Lab' for research");
    public ItemCreatorClass SciencePack10Item = new ItemCreatorClass(14, "Science Pack 10", SciencePack10Icon, "Used By 'Lab' for research");

    //Belts, Loaders, Inserter Icon//
    public ItemCreatorClass TransportBeltItem = new ItemCreatorClass(15, "Transport Belt", TransportBeltIcon, "A belt Which Transports Items");
    public ItemCreatorClass LoaderItem = new ItemCreatorClass(16, "Loader", LoaderIcon, "Loads Item from belt to container");
    public ItemCreatorClass InserterItem = new ItemCreatorClass(17, "Inserter", InserterIcon, "Takes Item from belt and places the item on the other side");

    //Coin Icon//
    public ItemCreatorClass CopperCoinItem = new ItemCreatorClass(18, "Copper Coin", CopperCoinIcon, "A Copper Coin");
    public ItemCreatorClass IronCoinItem = new ItemCreatorClass(19, "Iron Coin", IronCoinIcon, "An Iron Coin");
    public ItemCreatorClass PlatinumCoinItem = new ItemCreatorClass(20, "Platinum Coin", PlatinumCoinIcon, "A Platinum Coin");
    public ItemCreatorClass GoldCoinItem = new ItemCreatorClass(21, "Gold Icon", GoldCoinIcon, "A Gold Coin");

    //Misc Icon//
    public ItemCreatorClass MiningDrillItem = new ItemCreatorClass(22, "Mining Drill", MiningDrillIcon, "A drill which Digs Ore");
    public ItemCreatorClass ElectricPoleItem = new ItemCreatorClass(23, "Electric Pole", ElectricPoleIcon, "A Pole used to 'transport' electricity");
    public ItemCreatorClass BulletItem = new ItemCreatorClass(24, "Bullet", BulletIcon, "A simple Bullet");
    public ItemCreatorClass PistolItem = new ItemCreatorClass(25, "Pistol", PistolIcon, "A gun");
    public ItemCreatorClass MagazineItem = new ItemCreatorClass(26, "Magazine", MagazineIcon, "A small case which stores Bullet");

    //Stone Icon//
    public ItemCreatorClass StoneItem= new ItemCreatorClass(27, "Stone", StoneIcon, "");
    public ItemCreatorClass CrushedStoneItem = new ItemCreatorClass(28, "Crushed Stone", CrushedStoneIcon, "Stone thats been crushed");

    //Iron Icon//
    public ItemCreatorClass RoughIronOreItem = new ItemCreatorClass(29, "Rough Iron Ore", RoughIronOreIcon, "Iron Ore that has just been dug up from underground");
    public ItemCreatorClass CrushedIronOreItem = new ItemCreatorClass(30, "Crushed Iron Ore", CrushedIronOreIcon, "Iron Ore that have been Crushed");
    public ItemCreatorClass IronCrystalItem = new ItemCreatorClass(31, "Iron Crystal", IronCrystalIcon, "Bueatiful Iron Crystal that can be made in to pure ore");
    public ItemCreatorClass PurifiedIronOreItem = new ItemCreatorClass(32, "Purified Iron Ore", PurifiedIronOreIcon, "Sorted by Magnets so that it's pure");
    public ItemCreatorClass PureIronOreItem = new ItemCreatorClass(33, "Pure Iron Ore", PureIronOreIcon, "This can get Smelted");
    
    public ItemCreatorClass       = new ItemCreatorClass(34, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(35, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(36, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(37, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(38, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(39, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(40, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(41, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(42, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(43, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(44, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(45, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(46, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(47, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(48, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(49, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(50, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(51, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(52, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(53, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(54, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(55, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(56, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(57, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(58, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(59, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(60, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(61, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(62, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(63, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(64, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(65, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(66, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(67, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(68, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(69, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(71, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(72, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(73, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(74, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(75, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(76, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(77, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(78, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(79, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(80, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(81, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(82, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(83, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(84, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(85, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(86, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(87, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(88, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(89, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(90, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(91, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(92, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(93, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(94, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(95, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(96, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(97, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(98, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(99, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(100, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(101, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(102, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(103, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(104, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(105, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(106, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(107, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(108, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(109, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(110, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(111, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(112, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(113, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(114, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(115, "", Icon, "");
    public ItemCreatorClass       = new ItemCreatorClass(116, "", Icon, "");
    
    public class ItemCreatorClass
    {
        public int ID;
        public string Name;
        public Texture2D Icon;
        public string Description;

        public ItemCreatorClass(int IDD, string Namee, Texture2D Iconn, string Descriptionn)
        {
            ID = IDD;
            Name = Namee;
            Icon = Iconn;
            Description = Descriptionn;
        }
    }
    */
    
    
    
    
}   
    