using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreator : MonoBehaviour
{
    public GameObject coin,wood,barrier,barrier_warning,warning;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 300; i++)
        { 
            GameObject go = Instantiate(coin, new Vector3(1.84f, 7.219f, Random.Range(-1613.0f,2550.0f)), Quaternion.Euler(0, 0, 0));
            go = Instantiate(coin, new Vector3(-1.82f, 7.219f, Random.Range(-1613.0f,2550.0f)), Quaternion.Euler(0, 0, 0));
            go = Instantiate(coin, new Vector3(0.02f, 7.219f, Random.Range(-1613.0f,2550.0f)), Quaternion.Euler(0, 0, 0));

        }
        /*
        for (int i = 0; i < 100; i++)
        {
            GameObject go2 = Instantiate(wood, new Vector3(1.84f, 7.059f, Random.Range(-1613.0f, 2550.0f)), Quaternion.Euler(0, 0, 0));
            go2 = Instantiate(wood, new Vector3(-1.82f, 7.059f, Random.Range(-1613.0f, 2550.0f)), Quaternion.Euler(0, 0, 0));
            go2 = Instantiate(wood, new Vector3(0.02f, 7.059f, Random.Range(-1613.0f, 2550.0f)), Quaternion.Euler(0, 0, 0));
        }
        */
        for (int i = 0; i < 150; i++)
        {
            GameObject go3 = Instantiate(warning, new Vector3(1.84f, 6.86581f, Random.Range(-1595.21f, 2550.0f)), Quaternion.Euler(0, 270, 0));
            go3 = Instantiate(warning, new Vector3(-1.82f, 6.86581f, Random.Range(-1595.21f, 2550.0f)), Quaternion.Euler(0, 270, 0));
            go3 = Instantiate(warning, new Vector3(0.02f, 6.86581f, Random.Range(-1595.21f, 2550.0f)), Quaternion.Euler(0, 270, 0));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
