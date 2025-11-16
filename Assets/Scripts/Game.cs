using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup StartMenuCanvasGroup;
    public static bool IsGameStarted = false;

    public void Start()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }
    
    public void OnStartButtonClicked()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
        IsGameStarted = true;
    }
}