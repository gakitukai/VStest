using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilGenerator : MonoBehaviour
{
    [SerializeField] Transform[] spawnPosList;

    [SerializeField] GameObject devilPrefub;


    // Start is called before the first frame update
    void Start()
    {
        //定期的に繰り返しEnemyを生成する
        //InvokeRepeating(関数名, 開始時間, 生成間隔)
        InvokeRepeating("GenerateDevil", 60, 120);
    }

    void GenerateDevil()
    {
        //Instantiate(enemyPrefub, spawnPos.position, Quaternion.identity);

        //ランダムに0, 1, 2, 3のどれかを選ぶ
        int randomIndex = Random.Range(0, spawnPosList.Length);
        Debug.Log(randomIndex);
        Instantiate(devilPrefub, spawnPosList[randomIndex].position, Quaternion.identity);


    }
}// Start is called before the first frame update

