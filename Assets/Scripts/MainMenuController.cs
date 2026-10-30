using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuController : MonoBehaviour
{
    private UIDocument document;
    private Button button;
    private Button quitGame;
    private Slider slider;
    private Toggle toggle;

    void Start()
    {
        document = GetComponent<UIDocument>();
        button = document.rootVisualElement.Q<Button>("NewGame");
        quitGame = document.rootVisualElement.Q<Button>("Quit");
        slider = document.rootVisualElement.Q<Slider>("Slider");
        toggle = document.rootVisualElement.Q<Toggle>("Toggle");

        button.clicked += OnClickHandler;
        quitGame.clicked += OnQuitGameHandler;
        slider.RegisterValueChangedCallback(evt => SliderHandler());
        toggle.RegisterValueChangedCallback(evt => ToggleHandler());
    }

    // Buena practica de Unity - Limpieza de eventos
    private void OnDisable()
    {
        button.clicked -= OnClickHandler;
        quitGame.clicked -= OnQuitGameHandler;
    }

    private void OnClickHandler()
    {
        Debug.Log("Se presiono el boton...");
    }

    private void OnQuitGameHandler()
    {
        Debug.Log("Se presiono salir del juego...");
    }

    private void SliderHandler()
    {
        Debug.Log("El valor del slider/brillo/volumen es: " + slider.value);
    }

    private void ToggleHandler()
    {
        Debug.Log("El valor del V-Sync es: " + toggle.value);
    }
}