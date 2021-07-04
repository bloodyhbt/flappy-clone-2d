using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public BirdScript Flappy;

    public GameObject Tubes;
    public float height;

    public float time;


    private void Start ()
    {
        StartCoroutine(SpawnObject(time));

    }

    public IEnumerator SpawnObject(float time)
    {
        while (Flappy.isDead)
        {

            Instantiate(Tubes, new Vector3(3, Random.Range(-height,height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);

        }
        
    }
}
