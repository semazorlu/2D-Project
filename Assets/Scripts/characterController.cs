using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator _animator;
    private Vector3 charPos; //karakter pozisyonu
    private SpriteRenderer _spriteRenderer; //karakterin y�n� i�in
    [SerializeField] private GameObject _camera;
    private int sayi;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>(); //caching SpriteRenderer
        r2d = GetComponent<Rigidbody2D>();  //caching r2d
        _animator = GetComponent<Animator>();  //caching anim
        charPos = transform.position;
        sayi = 1;
    }

    private void FixedUpdate() 
    {
        sayi = 2;
    }
   
    void Update() // per frame
    {
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y); // deltatime her bir frame aras�ndaki zaman� tutuyor,
        //frame ler aras� ge�i� yaparken aradaki fark kadar h�zla �arp�m yap�p pozisyonu de�i�tirir
        transform.position = charPos; //hesaplad���m pozisyon karakterime i�lensin
        if (Input.GetAxis("Horizontal") == 0)
        {
            _animator.SetFloat("speed", 0.0f);
        }
        else
        {
            _animator.SetFloat("speed", 1.0f);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            _spriteRenderer.flipX = true;
        }
        sayi = 3;
    }

    private void LateUpdate()
    {
        sayi = 4;
    }

}
