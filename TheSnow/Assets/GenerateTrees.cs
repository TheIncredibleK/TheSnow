using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTrees : MonoBehaviour
{
    public GameObject treePrefab;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        int numTrees = chooseNumberOfTrees();

        spawnTrees(numTrees);

        Debug.Log(numTrees);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int chooseNumberOfTrees()
    {
        int trees = (int)Random.Range(4,5);
        return trees;
    }

    void spawnTrees(int numTrees)
    {
        for (int i=0; i < numTrees; i++)
        {
            spawnTree();
        }
    }

    void spawnTree()
    {
        Vector3 randomPosition = getRandomPosition();
        Debug.Log(randomPosition);
        GameObject tree = Instantiate(treePrefab, randomPosition, transform.rotation);
    }

    Vector3 getRandomPosition()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        float xScale = transform.localScale.x;
        float zScale = transform.localScale.z;

        float xRange = xScale/2;
        float zRange = zScale/2;

        return new Vector3(Random.Range(x -xRange, x + xRange), y, Random.Range(z -zRange, z + zRange));
    }
}
