﻿// =======================================================================================
// Created and maintained by Fhiz
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............: https://discord.gg/YkMbDHs
// * Public downloads website...........: https://www.indie-mmo.net
// * Pledge on Patreon for VIP AddOns...: https://www.patreon.com/IndieMMO
// =======================================================================================
using Mirror;
using UnityEngine;

// =======================================================================================
// FACTION
// =======================================================================================
public struct UCE_Faction
{
    public string name;
    public int rating;

    public UCE_Tmpl_Faction data
    {
        get
        {
            UCE_Tmpl_Faction _data;
            UCE_Tmpl_Faction.dict.TryGetValue(name.GetStableHashCode(), out _data);
            return _data;
        }
    }
}

// =======================================================================================
// FACTION RANK
// =======================================================================================
[System.Serializable]
public class UCE_FactionRank
{
    public string name;
    [Range(-9999, 9999)] public int min;
    [Range(-9999, 9999)] public int max;
}

// =======================================================================================
// FACTION RATING
// =======================================================================================
[System.Serializable]
public class UCE_FactionRating
{
    public UCE_Tmpl_Faction faction;
    [Range(-9999, 9999)] public int startRating;
}

// =======================================================================================
// FACTION REQUIREMENT
// =======================================================================================
[System.Serializable]
public class UCE_FactionRequirement
{
    public UCE_Tmpl_Faction faction;
    [Range(-9999, 9999)] public int min;
    [Range(-9999, 9999)] public int max;
}

// =======================================================================================
// FACTION QUEST
// =======================================================================================
[System.Serializable]
public class UCE_FactionQuest
{
    public UCE_Tmpl_Faction faction;
    [Range(-9999, 9999)] public int min;
}

// =======================================================================================
// FACTION MODIFIER
// =======================================================================================
[System.Serializable]
public class UCE_FactionModifier
{
    public UCE_Tmpl_Faction faction;
    [Range(-9999, 9999)] public int amount;
}

public class SyncListUCE_Faction : SyncList<UCE_Faction> { }

// =======================================================================================