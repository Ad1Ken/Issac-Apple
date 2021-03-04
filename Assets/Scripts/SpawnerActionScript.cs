using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerActionScript : MonoBehaviour
{
    public float width = 10f;
    public float height = 5f;
    public GameObject pianotile;
    public float delay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnUntil();
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }
    // Update is called once per frame
    void Update()
    {
        if(checkforempty())
        {
            SpawnUntil();
        }
    }
    public void Spawner()
    {
        foreach (Transform child in transform)
        {
            GameObject piano = Instantiate(pianotile, child.position, Quaternion.identity);
            piano.transform.parent = child;
        }
       
    }
     public void SpawnUntil()
    {
        Transform position = freeposition();
        if(position)
        {
            GameObject piano = Instantiate(pianotile, position.transform.position, Quaternion.identity);
            piano.transform.parent = position;
        }
        if (freeposition())
        {
            Invoke("SpawnUntil", delay);
        }
    }
    bool checkforempty()
    {
        foreach (Transform child in transform)
        {
           if(child.childCount>0)
            {
                return false;
            }
        }
        return true;
    }
    Transform freeposition()
    {
        foreach(Transform child in transform)
        {
            if(child.childCount==0)
            {
                return child;
            }
        }
        return null;
    }
}
