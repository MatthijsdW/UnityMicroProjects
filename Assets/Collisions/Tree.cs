using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Color hitColor;
    public MeshRenderer meshRenderer;

    private void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material.color = hitColor;
    }
}
