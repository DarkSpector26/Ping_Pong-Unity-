using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SceneLoader : MonoBehaviour
{

    public string sceneAddress = "DungeonLevel";

    // Load the addressable scene
    public void LoadScene()
    {
        
        Addressables.LoadSceneAsync(sceneAddress).Completed += OnSceneLoaded;
    }

   //when the scene is successfully loaded
    private void OnSceneLoaded(AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log("Scene Loaded Successfully: " + sceneAddress);
        }
        else
        {
            Debug.LogError("Failed to load scene: " + sceneAddress);
        }
    }

   
}
