using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Devil : MonoBehaviour
{
    [SerializeField] private int hp = 30;
    [SerializeField] Slider hpSlider;
    [SerializeField] GameManager gameManager;
    bool onDamage = false;
    float speed = 0.3f;
    GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        hero = GameObject.Find("Hero");


    }

    // Update is called once per frame
    void Update()
    {
        if (onDamage)
        {
            return;
        }
        if (Input.GetMouseButton(0))
        {
            transform.position = Vector3.MoveTowards(transform.position, hero.transform.position, Time.deltaTime * speed);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Weapon"))
        {
            if (onDamage == false)
            {

                hp -= 1;
                hpSlider.value = hp;
            }


            if (hp <= 0)
            {
                Destroy(gameObject);
                GameManager.instance.AddDestroyCount();
            }

        }
    }// Start is called before the first frame update
    
}
