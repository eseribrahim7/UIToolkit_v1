using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{

    private void Awake()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        root.Q<Button>("Play").clicked += () => Debug.Log("Play button clicked");
        root.Q<Button>("Settings").clicked += () => Debug.Log("Settings button clicked");
        root.Q<Button>("Quit").clicked += () => Debug.Log("Quit button clicked");
    }

}
