using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] managers;
    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < managers.Length; i++)
        {
            Instantiate(managers[i]);
        }

    }

}
