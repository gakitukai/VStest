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
    //����I�ɌJ��Ԃ�Enemy�𐶐�����
    //InvokeRepeating(�֐���, �J�n����, �����Ԋu)
    InvokeRepeating("GenerateDeth", 20, 20);
}

void GenerateDeth()
{
    //Instantiate(enemyPrefub, spawnPos.position, Quaternion.identity);

    //�����_����0, 1, 2, 3�̂ǂꂩ��I��
    int randomIndex = Random.Range(0, spawnPosList.Length);
    Debug.Log(randomIndex);
    Instantiate(dethPrefub, spawnPosList[randomIndex].position, Quaternion.identity);


}
}