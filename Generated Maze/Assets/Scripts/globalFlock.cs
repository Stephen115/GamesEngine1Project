using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour
{
    public GameObject fishPrefab;
    public GameObject goalPrefab;
    public static int tankSize = 150;
    private float Tankx;
    private float Tanky;
    private float Tankz;

    public static int numFish = 100;
    public static GameObject[] allFish = new GameObject[numFish];

    public static Vector3 goalPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Tankx = GameController.MazeBlockx * MazeMeshGenerator.widthSet;
        Tankz = GameController.MazeBlockz * MazeMeshGenerator.widthSet;
        Tanky = MazeMeshGenerator.heightSet;

        for (int i = 0; i < numFish; i++)
        {
            Vector3 pos = new Vector3(Random.Range(0, Tankx),
                                      Random.Range(0, Tanky),
                                      Random.Range(0, Tankz));
            allFish[i] = (GameObject) Instantiate(fishPrefab, pos, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 10000) < 50)
        {
            goalPos = new Vector3(Random.Range(0, Tankx),
                                  Random.Range(0, Tanky),
                                  Random.Range(0, Tankz));

            goalPrefab.transform.position = goalPos;
        }
    }
}
