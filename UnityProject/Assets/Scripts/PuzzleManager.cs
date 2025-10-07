using UnityEngine;
using TMPro;

public class PuzzleManager : MonoBehaviour
{
    [Header("Puzzle Settings")]
    public int puzzleValue = 0;
    public int requiredValue = 3; // how many switches to activate

    [Header("UI References")]
    public TMP_Text puzzleText;
    public TMP_Text completeText;

    void Start()
    {
        UpdatePuzzleUI();
        completeText.gameObject.SetActive(false);
    }

    public void AddValue(int amount)
    {
        puzzleValue += amount;
        UpdatePuzzleUI();

        if (puzzleValue >= requiredValue)
        {
            CompletePuzzle();
        }
    }

    void UpdatePuzzleUI()
    {
        puzzleText.text = puzzleValue + "/" + requiredValue;
    }

    void CompletePuzzle()
    {
        completeText.gameObject.SetActive(true);
        Debug.Log("Puzzle Complete!");
    }
}
