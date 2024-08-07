using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManager;

public class controladorMenu : MonoBehaviour
{
    private UIDocument document;
        private Button botao;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botao = document.rootVisualElement.Q<Button>("botao1");
        botao.RegisterCallback<ClickEvent>(onPlay);
    }
    void onPlay(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");
    }