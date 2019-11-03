﻿using Mirror;

// =======================================================================================
// TRAVELROUTE - CLASS
// =======================================================================================
[System.Serializable]
public struct UCE_TravelrouteClass
{
    public string name;

    public UCE_TravelrouteClass(string _name)
    {
        name = _name;
    }
}

public class SyncListUCE_TravelrouteClass : SyncList<UCE_TravelrouteClass> { }

// =======================================================================================