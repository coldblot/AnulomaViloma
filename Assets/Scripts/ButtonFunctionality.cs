using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour
{
    public Text topText;
    public Text topSecondText;
    private Button thisButton;
    [HideInInspector]public bool isSelected;
    private void Awake()
    {
        thisButton = GetComponent<Button>();
    }
    public void ChangeFonts()
    {
        topSecondText.color = Color.white;
        topText.color = Color.white;
        this.thisButton.GetComponent<Image>().color = Color.grey;
        isSelected = true;
    }
    public void ChangeFontsDefault()
    {
        topSecondText.color = Color.black;
        topText.color = Color.black;
        this.thisButton.GetComponent<Image>().color = Color.white;
        isSelected = false;
    }
}
