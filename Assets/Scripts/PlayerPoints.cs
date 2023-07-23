using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour //�d�llere tek tek script eklememek i�in (oyuncunun dokundu�unu etkilemesi i�in )
{
    [SerializeField] private TextMeshProUGUI _text;
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _text.text = Score.totalScore.ToString(); //farkl� sahneye ge�ince var olan scoredan devam etmek i�in
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Elmas"))
        {
            _audio.Play();//elmasa gelince ses olmas� i�in
            Destroy(other.gameObject);
            Score.totalScore++;
            _text.text = Score.totalScore.ToString();
        }
    }

}
