using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //seviyeler i�in gerekli olan k�t�phane

//hero ya player tag ini ekledik

public class Engel : MonoBehaviour
{
    private Scene _scene; //�u an ki sahnemle alakal� ?

    private void Awake() //bulundu�umuz sahneyi fonksiyon �al��t���nda anlamak i�in
    {
        _scene = SceneManager.GetActiveScene();
        Debug.Log(_scene.name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))   //e�er obje player ise seviyeyi yeniden ba�latmak i�in
        {
            Score.lives--;
            SceneManager.LoadScene(_scene.name);
        }
    }

}
