using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour
{

    [SerializeField] private string sceneToLoad = "_Scene_1";

    bool isLoading;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (isLoading) return;

        isLoading = true;
        Debug.Log($"[SceneSwitchTrigger] {other.name} chạm trigger, nạp scene {sceneToLoad}");
        SceneManager.LoadScene(sceneToLoad);
    }
}
