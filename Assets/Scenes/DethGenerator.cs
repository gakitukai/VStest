using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DethGenerator : MonoBehaviour
{ 
[SerializeField] Transform[] spawnPosList;

[SerializeField] GameObject dethPrefub;


// Start is called before the first frame update
void Start()
{
    //定期的に繰り返しEnemyを生成する
    //InvokeRepeating(関数名, 開始時間, 生成間隔)
    InvokeRepeating("GenerateDeth", 20, 20);
}

void GenerateDeth()
{
    //Instantiate(enemyPrefub, spawnPos.position, Quaternion.identity);

    //ランダムに0, 1, 2, 3のどれかを選ぶ
    int randomIndex = Random.Range(0, spawnPosList.Length);
    Debug.Log(randomIndex);
    Instantiate(dethPrefub, spawnPosList[randomIndex].position, Quaternion.identity);


}
}