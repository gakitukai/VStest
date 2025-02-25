using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    /// <summary>
    /// HPを保持
    [SerializeField] private int hp = 10;
    private int maxHp = 10;
    // Start is called before the first frame update
    [SerializeField] Slider hpSlider;
    

    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Time.timeScale = 1;
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 0;

            transform.position = Vector3.MoveTowards(transform.position, clickPosition, Time.deltaTime * 2f);
        }
        else
        {
            Time.timeScale = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collisiosn)
    {
    
     Debug.Log("衝突");
      //HP減らしたい
        hp -= 1;
        hpSlider.value = hp;
        if (hp <= 0)
        {
            hp = 0;
            GameManager.instance.GameOver();

          
        }

        else if (hp > maxHp)
        {
            hp = maxHp;
        }
    }
}
