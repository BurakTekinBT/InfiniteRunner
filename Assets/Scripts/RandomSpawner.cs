using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject obstacle;

    float timer;
    public float maxTime;
    public float maxX;
    public float minX;
    float randomZ;

    public void InstantiateObstacle() //onje oluþturacak sýnýf
    {

        randomZ = Random.Range(minX, maxX);

        GameObject newObstacle = Instantiate(obstacle); //neyi oluþuturacaðýz

        newObstacle.transform.position = new Vector3(transform.position.z, transform.position.y+2, randomZ);
    }

    // Start is called before the first frame update
    void Start()
    {

        //InstantiateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
            timer += Time.deltaTime;

            if (timer >= maxTime)

            {
                InstantiateObstacle();
                timer = 0;
            }
        
    }
}
//sürekli obje üretip yok etmek saðlýklý deðil farklý yöntem tercih edilir objectpool gibi
