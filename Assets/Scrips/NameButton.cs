using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameButton : MonoBehaviour {

    private int nameButton = 0;
    
    public int GetNameButton
    {
        get {
            return nameButton; 
        }

        set {
            nameButton = value;
        }
    }

}
