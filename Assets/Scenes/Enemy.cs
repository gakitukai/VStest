using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp = 3;
    [SerializeField] Sprite damageSprite;
    [SerializeField] Color damageColor;
    [SerializeField] Slider hpSlider;
    [SerializeField] GameManager gameManager;
    SpriteRenderer spriteRenderer;
    Sprite defaultSprite;
    bool onDamage = false;
    float speed = 0.4f;
    GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        hero = GameObject.Find("Hero");
        Destroy(gameObject, 10f);

        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultSprite = spriteRenderer.sprite;

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
                StartCoroutine(OnDamageAnim());

                hp -= 1;
                hpSlider.value = hp;
            }
            

            if (hp <= 0)
            {
                Destroy(gameObject);
                GameManager.instance.AddDestroyCount();
            }
        
        }
    }

    IEnumerator OnDamageAnim()
    {
        onDamage = true;

        spriteRenderer.sprite = damageSprite;

        spriteRenderer.color = damageColor;

        yield return new WaitForSeconds(0.3f);
        onDamage = false;

        spriteRenderer.sprite = defaultSprite;

        spriteRenderer.color = Color.white;
    }
}