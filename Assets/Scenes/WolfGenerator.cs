using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfGenerator : MonoBehaviour
{
    [SerializeField] Transform[] spawnPosList;

    [SerializeField] GameObject wolfPrefub;


    // Start is called before the first frame update
    void Start()
    {
        //定期的に繰り返しEnemyを生成する
        //InvokeRepeating(関数名, 開始時間, 生成間隔)
        InvokeRepeating("GenerateWolf", 9, 15);
    }

    void GenerateWolf()
    {
        //Instantiate(enemyPrefub, spawnPos.position, Quaternion.identity);

        //ランダムに0, 1, 2, 3のどれかを選ぶ
        int randomIndex = Random.Range(0, spawnPosList.Length);
        Debug.Log(randomIndex);
        Instantiate(wolfPrefub, spawnPosList[randomIndex].position, Quaternion.identity);


    }
}
// Start is called before the first frame update



