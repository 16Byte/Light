using UnityEngine;
using System.Collections;

public class ResetLevel : MonoBehaviour {

    private int level = Application.loadedLevel;

    void OnGUI()
    {
        if(GUI.Button(new Rect(10, 10, 50, 25), "Reset")) {
            Application.LoadLevel(level);
        }
    }

}
