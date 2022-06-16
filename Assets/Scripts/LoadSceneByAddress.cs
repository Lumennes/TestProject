using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

internal class LoadSceneByAddress : MonoBehaviour
{
    public string key; // address string
    private AsyncOperationHandle<SceneInstance> loadHandle;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        loadHandle = Addressables.LoadSceneAsync(key/*, LoadSceneMode.Additive*/);
    }

    void OnDestroy()
    {            
        Addressables.UnloadSceneAsync(loadHandle);
    }
}