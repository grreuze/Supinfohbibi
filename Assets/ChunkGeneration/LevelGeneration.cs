using System.Collections;
using UnityEngine;

public class LevelGeneration : MonoBehaviour {

    public static LevelGeneration ins;

    //SEED
    public string Seed;
    string[] choppedSeed;

    //chunks spéciaux
    public GameObject FinalChunkPrefab;

    //l'array de chunks
    public GameObject[] Chunks;

    [HideInInspector]
    public Transform CurrentEndPoint;

    [HideInInspector]
    public float currentLength;

    //INTS
    //nombre de chunks instanciés
    private int chunkScore;
    //le chunk précédemment instancié (pour éviter les doublons)
    private int previousChunkIndex;
    //l'int random pour pick le chunk a instancier
    private int chunkIndexer;
    //la longueur de la run
    public int runLength;

    //BOOLS
    //détermine si on peut instancier ou pas de nouveaux chunks
    private bool canGenerate = true;

    //Singleton
    private void Awake() {
        if (LevelGeneration.ins == null) {
            LevelGeneration.ins = this;
        } else {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start() {

        GenerateSeed();
        ChopSeed();

        chunkScore = 0;

        StartCoroutine(GenerationCoroutine());
        
    }

    public void Generate(int ind)
    {

        if (chunkScore == runLength && canGenerate)
        {
            GameObject finalChunk = Instantiate(FinalChunkPrefab, CurrentEndPoint.position, Quaternion.Euler(CurrentEndPoint.eulerAngles.x, CurrentEndPoint.eulerAngles.y, CurrentEndPoint.eulerAngles.z));
            canGenerate = false;
        }
        else if (canGenerate)
        {
            
            //Instanciation du préfab
            GameObject newChunk = Instantiate(Chunks[ind], CurrentEndPoint.position, Quaternion.Euler(CurrentEndPoint.eulerAngles.x, CurrentEndPoint.eulerAngles.y, CurrentEndPoint.eulerAngles.z));

            chunkScore++;
        }
    }

    //vérifie que le random est bien valide (avec exception au tout début)
    bool CheckChunkValidity(int ind) {
        if (chunkScore == 0)
            return false;

        if (ind != previousChunkIndex)
            return false;
        else return true;
    }

    private void ChopSeed()
    {
        choppedSeed = Seed.Split(" "[0]);
    }

    private void GenerateSeed()
    {
        Seed = string.Empty;

        for(int i = 0; i < runLength; i++)
        {
            do
            {
                chunkIndexer = Random.Range(0, Chunks.Length);
            } while (CheckChunkValidity(chunkIndexer));

            previousChunkIndex = chunkIndexer;
            chunkScore++;

            //append
            Seed += chunkIndexer.ToString() + " "; 
        }
    }

    IEnumerator GenerationCoroutine()
    {
        for (int i = 0; i < runLength; i++)
        {
            yield return new WaitForEndOfFrame();

            //générer chunk par chunk
            Generate(int.Parse(choppedSeed[i]));         
        }

        yield return null;
    }
}
