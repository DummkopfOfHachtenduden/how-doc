public enum ItemType : byte
{
    None = 0x00,
    Trotter = 0x01,
    Knife = 0x02,
    Bayonet = 0x03,
    Sword = 0x04,
    CattleProd = 0x05,
    Pistol = 0x06,
    Rifle = 0x07,
    RifleBurst = 0x08,
    MachineGun = 0x09,
    HeavyMachineGun = 0x0A,
    SniperRifle = 0x0B,
    Shotgun = 0x0C,
    Flamethrower = 0x0D,
    Rocketlauncher = 0x0E,
    GuidedMissile = 0x0F,
    MedicineDart = 0x10,
    Tranquilizer = 0x11,
    Grenade = 0x12,
    ClusterGrenade = 0x13,
    HXGrenade = 0x14,
    RollerGrenade = 0x15,
    ConfusionGas = 0x16,
    FreezeGas = 0x17,
    MadnessGas = 0x18,
    PoisonGas = 0x19,
    Mortar = 0x1A,
    Bazooka = 0x1B,
    Airburst = 0x1C,
    SuperAirburst = 0x1D,
    MedicineBall = 0x1E,
    HomingMissile = 0x1F,
    Mine = 0x20,
    AntiPMine = 0x21,
    TNT = 0x22,

    //Vehicle weapons
    VehLongRangeShell = 0x23,
    VehShockShell = 0x24,
    Veh1000LBSShell = 0x25,
    VehFireShell = 0x26,
    VehGasShell = 0x27,
    VehMineShell = 0x28,
    VehHeavyMachineGun = 0x29,
    VehFlamethrower = 0x2A,
    VehAirburst = 0x2B,
    VehBazooka = 0x2C,
    VehMortar = 0x2D,

    //Missing 0x2E
    //Missing 0x2F
    //Missing 0x30
    //Missing 0x31
    //Missing 0x32
    
    Jetpack = 0x33,
    Suicide = 0x34,
    HealingHands = 0x35,
    SelfHeal = 0x36,
    PickPocket = 0x37,
    Shockwave = 0x38,
    SpecialOps = 0x39,
    Airstrike = 0x3A,
    FireRainAirstrike = 0x3B,

    //Tools
    VehicleInOut = 0x3C,
    BuildingInOut = 0x3D,
    EjectPig = 0x3E,
    MapView = 0x3F,
    Binoculars = 0x40,
    SkipTurn = 0x41,
    Surrender = 0x42,
    
    SuperTNT = 0x43,
    Hide = 0x44,
    SuperShotgun = 0x45,
    ShrapnelGrenade = 0x46,
    GrenadeLauncher = 0x47,

    //Missing 0x48

    Random = 0x49,
    Health = 0xFF,
}