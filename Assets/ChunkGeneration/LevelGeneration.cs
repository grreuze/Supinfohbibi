﻿using System.Collections;
using UnityEngine;

public class LevelGeneration : MonoBehaviour {

    public static LevelGeneration ins;

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
        StartCoroutine(GenerationCoroutine());
    }

    public void Generate() {
        if (chunkScore == runLength && canGenerate) {
            GameObject finalChunk = Instantiate(FinalChunkPrefab, CurrentEndPoint.position, Quaternion.Euler(CurrentEndPoint.eulerAngles.x, CurrentEndPoint.eulerAngles.y, CurrentEndPoint.eulerAngles.z));
            canGenerate = false;
        } else if (canGenerate) {
            //on interdit les doublons de chunks via un do/while
            do {
                chunkIndexer = Random.Range(0, Chunks.Length);
            } while (CheckChunkValidity(chunkIndexer));

            previousChunkIndex = chunkIndexer;

            //Instanciation du préfab
            GameObject newChunk = Instantiate(Chunks[chunkIndexer], CurrentEndPoint.position, Quaternion.Euler(CurrentEndPoint.eulerAngles.x, CurrentEndPoint.eulerAngles.y, CurrentEndPoint.eulerAngles.z));

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

    private IEnumerator GenerationCoroutine() {
        for (int i = 0; i < runLength + 1; i++) {
            Generate();
            yield return new WaitForEndOfFrame();
        }

        yield return null;
    }
}
