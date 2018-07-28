using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ansver : MonoBehaviour {

    public Sprite layer_Up, layer_Down;

    private GameObject mainCube;

    void Start()
    {
        mainCube = GameObject.Find("Button");
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_Down;

        if (GetComponent<NameButton>().GetNameButton == mainCube.GetComponent<ControlGame>().GetNamAnsve())
        {
            mainCube.GetComponent<ControlGame>().SetResultNamber();
        }
        mainCube.GetComponent<ControlGame>().next = true;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_Up;
    }
}
