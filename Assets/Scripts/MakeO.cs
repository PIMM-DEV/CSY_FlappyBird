using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeO : MonoBehaviour
{
    public GameObject Obstacle;
    public float timeDiff;
    float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newObstacle = Instantiate(Obstacle);
            newObstacle.transform.position = new Vector3(3.5f, Random.Range(-2.2f,2.9f), 0);
            timer = 0;
            Destroy(newObstacle, 5.0f);
        }
    
        
       
    }
}
