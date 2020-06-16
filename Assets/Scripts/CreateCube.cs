using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    //public GameObject m_goPrefab = null;

    void Start()
    {
        StartCoroutine(CreateCoroutine());
    }
    

    IEnumerator CreateCoroutine()
    {
        while(true)
        {
            yield return null;
            //Instantiate(m_goPrefab, Vector3.zero, Quaternion.identity);
            GameObject t_object = ObjectPoolingManager.instance.GetQueue();
            t_object.transform.position = Vector3.zero;
        }
    }
}
