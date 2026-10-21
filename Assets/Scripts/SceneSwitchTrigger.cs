using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour
{

    public Canvas GameMenu;

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
        GameMenu.enabled = true;  
    }
}
