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
        //����I�ɌJ��Ԃ�Enemy�𐶐�����
        //InvokeRepeating(�֐���, �J�n����, �����Ԋu)
        InvokeRepeating("GenerateDevil", 60, 120);
    }

    void GenerateDevil()
    {
        //Instantiate(enemyPrefub, spawnPos.position, Quaternion.identity);

        //�����_����0, 1, 2, 3�̂ǂꂩ��I��
        int randomIndex = Random.Range(0, spawnPosList.Length);
        Debug.Log(randomIndex);
        Instantiate(devilPrefub, spawnPosList[randomIndex].position, Quaternion.identity);


    }
}// Start is called before the first frame update

