using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPosition = 80;
    public bool creatingSection = false;
    public int sectionNumber;


    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0, 3);
        Instantiate(section[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
        zPosition += 80;
        yield return new WaitForSecondsRealtime(5);
        creatingSection = false;
    }
}
