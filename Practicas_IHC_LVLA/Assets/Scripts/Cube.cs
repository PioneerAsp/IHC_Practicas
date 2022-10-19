using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Interactable
{
    public Material activeMaterial;
    public Material inactiveMaterial;
    private MeshRenderer meshRenderer;

    private void Start(){
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = inactiveMaterial;
    }
    public override void Interact(){
        base.Interact();
        meshRenderer.material = activeMaterial;
        //Logica de interaccion del cubo
    }
}
