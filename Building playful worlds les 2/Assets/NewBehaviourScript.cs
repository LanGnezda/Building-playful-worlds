using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public Color Objectcolor = new Color();
    public Renderer objectRenderer;

    // Use this for initialization
    void Start () { 

        objectRenderer.material.color = Objectcolor;
       
	}
	
	// Update is called once per frame
	void Update () {
    
	}
}
