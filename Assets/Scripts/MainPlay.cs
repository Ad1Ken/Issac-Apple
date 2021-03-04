using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlay : MonoBehaviour
{
    public GameObject MainCatchy;
    public GameObject Border;

    private float min_X = -2.6f;
    private float max_X = 2.6f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // Update is called once per frame

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));

        GameObject k = Instantiate(MainCatchy);

        float x = Random.Range(min_X, max_X);

        k.transform.position = new Vector2(x, transform.position.y);

        StartCoroutine(StartSpawning());
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Border")
        {
            Destroy(MainCatchy);
        }
        

    }
}
