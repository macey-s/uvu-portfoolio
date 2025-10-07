using UnityEngine;

public class Switch : MonoBehaviour
{
    public int value = 1; // how much to add
    public Material offMaterial;
    public Material onMaterial;

    private bool isActivated = false;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = offMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isActivated && other.CompareTag("Player"))
        {
            Debug.Log("Switch activated!");
            isActivated = true;

            // change material
            meshRenderer.material = onMaterial;

            // notify the PuzzleManager
            PuzzleManager puzzleManager = FindObjectOfType<PuzzleManager>();
            if (puzzleManager != null)
            {
                puzzleManager.AddValue(value);
            }
        }
    }
}
