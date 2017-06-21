public enum ScriptType : ushort
{
    None = 0,

    /// <summary>
    /// Spawns an ITEM at script location.
    /// </summary>
    SpawnItemKill = 1,

    /// <summary>
    /// Spawns a PROPOINT at script location.
    /// </summary>
    SpawnPropointKill = 2,

    /// <summary>
    /// Rewards PROPOINT when object is not destroyed.
    /// </summary>
    Protect = 4,

    /// <summary>
    /// Triggers an ITEM airdrop at script location
    /// </summary>
    AirdropItem = 7,

    /// <summary>
    /// Triggers a PROPOINT airdrop at script location
    /// </summary>
    AirdropPropoint = 8,

    /// <summary>
    /// Spawns an ITEM at script location when group is killed
    /// </summary>
    SpawnItemKillGroup = 13,

    /// <summary>
    /// Spawns a PROPOINT at script location when group is killed
    /// </summary>
    SpawnPropointKillGroup = 14,

    /// <summary>
    /// Sets a pickup reward [param0] and amount [param1]
    /// </summary>
    SetItem = 19,

    /// <summary>
    /// Spawns group [param0] when killed
    /// </summary>
    TutorialKill = 20,

    /// <summary>
    /// Trigger victory when group is killed
    /// </summary>
    TutorialEnd = 21,

    /// <summary>
    /// Activates group [param0] when object is bursted by TNT
    /// </summary>
    TutorialBurst = 22,

    /// <summary>
    /// Spawns group [param0] when object's group is killed
    /// </summary>
    TutorialKillGroup = 23,
}