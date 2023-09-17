using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventPortalFlickering : MonoBehaviour
{

    MeshRenderer renderer;
    public MeshRenderer renderer2;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            renderer.enabled = true;
            renderer2.enabled = true;
        }
    }

}
