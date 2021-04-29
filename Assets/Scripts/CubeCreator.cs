using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour
{
    public GameObject cubePrefab = null;

    public int myNumber;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cubePrefab, new Vector3(5, 1, 2), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
