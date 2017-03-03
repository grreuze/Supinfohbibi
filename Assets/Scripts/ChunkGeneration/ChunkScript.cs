using UnityEngine;

public class ChunkScript : MonoBehaviour {

    //la fin du chunk, qui détermine l'endroit et la rotation du prochain chunk instancié
    public Transform EndPoint;

    //Le parent de tous les collectibles du chunk, doit être disabled par défaut
    public GameObject Collectibles;

    [HideInInspector]
    public float chunkLength;

    int randomIndexer;

    private void Start()
    {
        CalculateChunkLength();
        if (LevelGeneration.ins)
            Calibrate();

        if(Collectibles != null)
        {
            randomIndexer = Random.Range(0, 100);

            if (randomIndexer <= 33)
            {
                Collectibles.SetActive(true);
            }
        }
        
    }

    public void CalculateChunkLength()
    {
        //on crée 2 nouveaux vecteurs avec les positions de départ et d'arrivée mais au même niveau en Y.
        Vector3 FlatStart = new Vector3(transform.position.x, 0, transform.position.z);
        Vector3 FlatEnd = new Vector3(EndPoint.position.x, 0, EndPoint.position.z);

        //on calcule la distance "flat" entre les 2 points
        chunkLength = Vector3.Distance(FlatStart, FlatEnd);
    }

    //calibration du LevelGeneration (mise à jour des variables)
    public void Calibrate() {
        LevelGeneration.ins.CurrentEndPoint = EndPoint;
        LevelGeneration.ins.currentLength = chunkLength;
    }
}
