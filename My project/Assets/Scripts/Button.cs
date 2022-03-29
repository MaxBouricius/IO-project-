using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    GameObject[] buttons;
    GameObject currentButton;
    int index;

    public void click()
    {
        buttons = GameObject.FindGameObjectsWithTag("point");
        index = Random.Range(0, buttons.Length);
        currentButton = buttons[index];
        print(currentButton.name);

    }

}
