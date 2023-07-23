using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private Scene _scene;

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))   //e�er obje player ise seviyeyi yeniden ba�latmak i�in
        {
            SceneManager.LoadScene(_scene.buildIndex + 1);
        }
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
}
