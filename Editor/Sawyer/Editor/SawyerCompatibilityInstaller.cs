using UnityEngine;
using UnityEditor;
using Sawyer.Editor.Compatibility;

public class SawyerCompatibilityInstaller
{
    [InitializeOnLoadMethod]
    static void Initialize()
    {
        Debug.Log("Sawyer Compatibility Package Loaded!");
        Debug.Log($"Unity Version: {Application.unityVersion}");
        Debug.Log($"Compatibility Layer Status: Initialized");
        Debug.Log($"Supported Versions: Unity 2022.x, 2023.3+, 6.x+");
        
        // Test compatibility layer
        Debug.Log($"Unity Version Detection:");
        Debug.Log($"  IsUnity2022: {UnityCompatibilityLayer.IsUnity2022}");
        Debug.Log($"  IsUnity2023OrNewer: {UnityCompatibilityLayer.IsUnity2023OrNewer}");
        Debug.Log($"  IsUnity6OrNewer: {UnityCompatibilityLayer.IsUnity6OrNewer}");
        
        // Test JSON namespace detection
        Debug.Log($"JSON Namespace: {UnityCompatibilityLayer.GetJsonNamespace()}");
    }
}