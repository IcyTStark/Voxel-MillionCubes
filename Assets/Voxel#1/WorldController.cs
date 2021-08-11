using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public GameObject block;
    public int depth = 10, height = 10, width = 10;

    private void Start()
    {
        StartCoroutine(BuildWorld());
    }

    public IEnumerator BuildWorld()
    {
        for (int z = 0; z < depth; z++)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Vector3 pos = new Vector3(x, y, z);
                    GameObject cube = Instantiate(block, pos, Quaternion.identity);
                    cube.name = x + "_" + y + "_" + z;
                    cube.GetComponent<Renderer>().material.color = Random.ColorHSV();
                }
                yield return null;
            }
        }
    }
}
