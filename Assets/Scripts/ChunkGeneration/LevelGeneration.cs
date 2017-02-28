using UnityEngine;

public class LevelGeneration : MonoBehaviour {

    public static LevelGeneration ins;

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

    //Singleton
    private void Awake()
    {
        if(LevelGeneration.ins == null)
            LevelGeneration.ins = this;
        else
            Destroy(gameObject);

        CurrentEndPoint = transform;
    }
    
    public void Generate()
    {
        //on interdit les doublons de chunks via un do/while
        do
        {
            chunkIndexer = Random.Range(0, Chunks.Length);
        } while (CheckChunkValidity(chunkIndexer));
        
        previousChunkIndex = chunkIndexer;
        
        //Instanciation du préfab
        GameObject newChunk = Instantiate(Chunks[chunkIndexer], CurrentEndPoint.position, CurrentEndPoint.rotation);

        DoSpline(newChunk.transform, newChunk.GetComponent<ChunkScript>().EndPoint);

        chunkScore++;
    }

    BezierSpline spline;
    void DoSpline(Transform startPoint, Transform endPoint) {

        if (!spline) {
            spline = gameObject.AddComponent<BezierSpline>();
            spline.Reset();

        } else {
            spline.AddCurve();
        }

        int pointCount = spline.ControlPointCount;

        // START POINT
            spline.SetControlPoint(pointCount-4, startPoint.position);
            // Bezier
            Vector3 startOffset = startPoint.right * 2;
            if (pointCount > 4) {
                spline.SetControlPoint(pointCount - 5, startPoint.position + startOffset);
            }
            spline.SetControlPoint(pointCount - 3, startPoint.position - startOffset);

        // END POINT
            spline.SetControlPoint(pointCount-1, endPoint.position);
        // Bezier
            Vector3 endOffset = endPoint.right * 2;
            spline.SetControlPoint(pointCount - 2, endPoint.position + endOffset);
    }


    //vérifie que le random est bien valide (avec exception au tout début)
    bool CheckChunkValidity(int ind)
    {
        if (chunkScore == 0)
            return false;

        return ind == previousChunkIndex;
    }
}
