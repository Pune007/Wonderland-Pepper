using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlayPlatform : MonoBehaviour
{
    private ManageScenes sceneManager;
    [SerializeField] private int scenario;

    void Awake()
    {
        sceneManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<ManageScenes>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the triggering object is tagged as "Ball"
        if (other.CompareTag("Ball"))
        {
            sceneManager.NewScene(scenario);
        }
    }
}
