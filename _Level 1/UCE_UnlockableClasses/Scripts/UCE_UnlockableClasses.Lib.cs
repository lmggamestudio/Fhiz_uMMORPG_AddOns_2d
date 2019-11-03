#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class UnlockableClassesLib
{
    private const string define = "_iMMOUNLOCKABLECLASSES";

    static UnlockableClassesLib()
    {
        AddLibrayDefineIfNeeded();
    }

    private static void AddLibrayDefineIfNeeded()
    {
        BuildTargetGroup buildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        string definestring = PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup);
        string[] defines = definestring.Split(';');

        if (Contains(defines, define))
            return;

        PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTargetGroup, (definestring + ";" + define));
    }

    private static bool Contains(string[] defines, string define)
    {
        foreach (string def in defines)
        {
            if (def == define)
                return true;
        }
        return false;
    }
}

#endif