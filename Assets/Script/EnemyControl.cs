using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    GameObject scoreUITextGO;//Посилання на ігровий об’єкт текстового інтерфейсу користувача
    public GameObject ExplosionGO; // prefab вибуха

    float speed;//для швидкості ворога


    // Use this for initialization
    void Start ()
    {
        speed = 2f;//задана швидкість

        //Отримати результат текстy UI
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreTextTag");
    }

    // Update is called once per frame
    void Update ()
    {
        // Поточна позиція противника
        Vector2 position = transform.position;


        // Обчисленя  нової позиції противника
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);

        //Oновлення позиції ворога
        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        //Якщо ворог вийшов за межі екрану , знищити ворога
        if (transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        //Виявленя зіткнення ворожого корабля з кораблем гравця ,або з кулею гравця
        if ((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            PlayExplosion();
            //Додати 100 очок до рахунку
            scoreUITextGO.GetComponent<GameScore>().Score += 100;
            //Знищити корабель
            Destroy(gameObject);
        }
    }
    //Функція для створення вибуху
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }
}
