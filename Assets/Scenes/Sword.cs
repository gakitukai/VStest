using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(Swing());
    }
    IEnumerator Swing()
    {
        while (true)
        {
            transform.localPosition = new Vector3(1.2f, -0.15f, 0);

            transform.localRotation = Quaternion.Euler(0, 0, -90);

            yield return new WaitForSeconds(0.5f);

            transform.localPosition = new Vector3(0, -1.2f, 0);

            transform.localRotation = Quaternion.Euler(0, 0, 180);

            yield return new WaitForSeconds(0.5f);

            transform.localPosition = new Vector3(-1.2f, -0.15f, 0);

            transform.localRotation = Quaternion.Euler(0, 0, 90);
            
            yield return new WaitForSeconds(0.5f);

            

            transform.localPosition = new Vector3(0, 1.2f, 0);

            transform.localRotation = Quaternion.Euler(0, 0, 0);

            yield return new WaitForSeconds(0.5f);
        }


    }
    
    // Update is called once per frame
    
    
}
