using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //敵を生成する
    //Prefubを用意してInstantiateする
    //1．Prefubを用意
    //2．PrefubをInstantiateする
    //3．Enemyを複数箇所から生成する
    //　　　　⇒配列を使う

    //生成場所
    //[SerializeField] Transform spawnPos;
    [SerializeField] Transform[] spawnPosList;

    [SerializeField] GameObject enemyPrefub;


    // Start is called before the first frame update
    void Start()
    {
        //定期的に繰り返しEnemyを生成する
        //InvokeRepeating(関数名, 開始時間, 生成間隔)
        InvokeRepeating("GenerateEnemy", 2, 4);
    }

    void GenerateEnemy()
    {
        //Instantiate(enemyPrefub, spawnPos.position, Quaternion.identity);

        //ランダムに0, 1, 2, 3のどれかを選ぶ
        int randomIndex = Random.Range(0, spawnPosList.Length);
        Debug.Log(randomIndex);
        Instantiate(enemyPrefub, spawnPosList[randomIndex].position, Quaternion.identity);

        
    }
}