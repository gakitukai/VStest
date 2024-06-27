using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //�G�𐶐�����
    //Prefub��p�ӂ���Instantiate����
    //1�DPrefub��p��
    //2�DPrefub��Instantiate����
    //3�DEnemy�𕡐��ӏ����琶������
    //�@�@�@�@�˔z����g��

    //�����ꏊ
    //[SerializeField] Transform spawnPos;
    [SerializeField] Transform[] spawnPosList;

    [SerializeField] GameObject enemyPrefub;


    // Start is called before the first frame update
    void Start()
    {
        //����I�ɌJ��Ԃ�Enemy�𐶐�����
        //InvokeRepeating(�֐���, �J�n����, �����Ԋu)
        InvokeRepeating("GenerateEnemy", 2, 4);
    }

    void GenerateEnemy()
    {
        //Instantiate(enemyPrefub, spawnPos.position, Quaternion.identity);

        //�����_����0, 1, 2, 3�̂ǂꂩ��I��
        int randomIndex = Random.Range(0, spawnPosList.Length);
        Debug.Log(randomIndex);
        Instantiate(enemyPrefub, spawnPosList[randomIndex].position, Quaternion.identity);

        
    }
}