using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContolButtonLose : MonoBehaviour {

    public Sprite layer_blue, layer_red;

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_red;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_blue;
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "ButtonHome":
                SceneManager.LoadScene("MainScen");
                break;
            case "ButtonCurved":
                SceneManager.LoadScene("ColectionsTest");
                break;
        }
    }
}
