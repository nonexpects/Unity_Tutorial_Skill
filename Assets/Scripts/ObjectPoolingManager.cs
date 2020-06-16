using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    public static ObjectPoolingManager instance;

    public GameObject m_goPrefab = null;

    public Queue<GameObject> m_queue = new Queue<GameObject>();
    void Start()
    {
        instance = this;
        for (int i = 0; i < 500; i++)
        {
            GameObject t_object = Instantiate(m_goPrefab, Vector3.zero, Quaternion.identity);
            m_queue.Enqueue(t_object);
            t_object.SetActive(false);
        }
    }

    public void InsertQueue(GameObject obj)
    {
        m_queue.Enqueue(obj);
        obj.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject t_objecct = m_queue.Dequeue();
        t_objecct.SetActive(true);
        return t_objecct;
    }
}
