using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    IEnumerator Start()
    {
        var knightSpawner:GameObject = GameObject.Find("KnightSpawner");
        knightSpawner.SetActive(false);
        yield return new WaitForSeconds(5f);
        knightSpawner.SetActive(true);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var gates:GameObject[] = GameObject.FindGameObjectsWithTag("Gate");
            foreach(var gate:GameObject in gates)
            {
               var renderer = gate.GetComponent<Renderer>();
                if(renderer != null)
                renderer.material.color = Color.red;
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            var gates:GameObject[] = GameObject.FindGameObjectsWithTag("Gate");
            foreach (var gate:GameObject in gates)
            {
                var renderer = gate.GetComponent<Renderer>();
                if (renderer != null)
                    renderer.material.color = Color.white;
            }
        }
    }
}
