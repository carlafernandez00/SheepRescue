﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

//Inhering from IPointerClickHandler -> to receive OnPointerClick callbacks
public class QuitButton : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.Quit();  //quit game
    }
}
