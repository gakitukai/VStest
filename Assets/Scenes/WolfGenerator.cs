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
        //����I�ɌJ��Ԃ�Enemy�𐶐�����
        //InvokeRepeating(�֐���, �J�n����, �����Ԋu)
        InvokeRepeating("GenerateWolf", 9, 15);
    }

    void GenerateWolf()
    {
        //Instantiate(enemyPrefub, spawnPos.position, Quaternion.identity);

        //�����_����0, 1, 2, 3�̂ǂꂩ��I��
        int randomIndex = Random.Range(0, spawnPosList.Length);
        Debug.Log(randomIndex);
        Instantiate(wolfPrefub, spawnPosList[randomIndex].position, Quaternion.identity);


    }
}
// Start is called before the first frame update



