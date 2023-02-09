using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    #region Buttons Main Panel
    public Button kappalBhatiButton;
    public Button anulomaVilomaButton;
    public Button meditationTimerButton;

    public Button nextButton;
    #endregion
    private void Awake()
    {
        kappalBhatiButton.onClick.AddListener(()=>ButtonFunctionality("kappal"));
        anulomaVilomaButton.onClick.AddListener(() => ButtonFunctionality("anuloma"));
        meditationTimerButton.onClick.AddListener(() => ButtonFunctionality("meditation"));
    }

    private void ButtonFunctionality(string name)
    {
        ButtonFunctionality buttonFunctionality = null;
        switch (name)
        {
            case "kappal":
                buttonFunctionality = kappalBhatiButton.GetComponent<ButtonFunctionality>();
                anulomaVilomaButton.GetComponent<ButtonFunctionality>().ChangeFontsDefault();
                meditationTimerButton.GetComponent<ButtonFunctionality>().ChangeFontsDefault();
                break;
            case "anuloma":
                buttonFunctionality = anulomaVilomaButton.GetComponent<ButtonFunctionality>();
                kappalBhatiButton.GetComponent<ButtonFunctionality>().ChangeFontsDefault();
                meditationTimerButton.GetComponent<ButtonFunctionality>().ChangeFontsDefault();
                break;
            case "meditation":
                buttonFunctionality = meditationTimerButton.GetComponent<ButtonFunctionality>();
                kappalBhatiButton.GetComponent<ButtonFunctionality>().ChangeFontsDefault();
                anulomaVilomaButton.GetComponent<ButtonFunctionality>().ChangeFontsDefault();
                break;
        }
        buttonFunctionality.ChangeFonts();
    }
}
