using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metrics : MonoBehaviour {

    public static Metrics ins;

    //Classes
    EndRun ER;
    public Points Pts;

    //Ints
    private int numberOfRuns = 0;
    private int totalJumps = 0;
    private int totaljumpsWithTricks = 0;

    //Bools
    private bool hasSeenOptions = false;
    private bool hasSeenCredits = false;

    //Floats
    private float timer = 0f;
    private float averageSkillLevelAtStartOfSession;

    //Listes
    private List<int> allTrickScores = new List<int>();

    //Singleton
    private void Awake()
    {
        if (Metrics.ins == null)
            Metrics.ins = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }

    public void Setup()
    {
        ER = FindObjectOfType<EndRun>();

        //setup des trucs techniques
        Amplitude.Instance.logging = true;
        Amplitude.Instance.init("e0c41856e17ab291ef2757bbc4fe19ec");   
        Amplitude.Instance.startSession();   

        //détection de l'heure de lancement de session et du modèle de téléphone
        var customProperties = new Dictionary<string, object>
        {
            {"Date", System.DateTime.UtcNow.ToString("HH:mm dd MMMM yyyy") },
            {"Device model", SystemInfo.deviceModel },
            {"Android Version", SystemInfo.operatingSystem }
        };

        Amplitude.Instance.logEvent("Session Started", customProperties);

        averageSkillLevelAtStartOfSession = ER.PlayerStats.averageSkillLevel;
    }

    private void Update()
    {
        timer += Time.deltaTime;
    }

    //stocke de manière continue des données au cours de la session
    void FillTrackingProperties(Dictionary<string, object> properties)
    {
        //track le score du joueur
        properties["score"] = Pts.points;
    }


    public void StartRun()
    {
        numberOfRuns++;
        Amplitude.Instance.logEvent("Run Started");
        timer = 0;

        totalJumps = 0;
        totaljumpsWithTricks = 0;
    }

    public void OpenedCredits()
    {
        hasSeenCredits = true;
    }

    public void OpenedOptions()
    {
        hasSeenOptions = true;
    }

    //à appeler chaque fois que le joueur atterrit
    public void LogEndTrick(int num)
    {
        if(num > 0)
        {
            allTrickScores.Add(num);
            totaljumpsWithTricks++;
        }
    }

    public void LogJump()
    {
        totalJumps++;
    }

    public void FinishRun( int rank)
    {
        //calcul du nombre moyen de tricks par saut
        float totalTrickNum = 0;

        for(int i = 0; i < allTrickScores.Count; i++)
        {
            totalTrickNum += allTrickScores[i];
        }

        float jumpRatio;

        //calcul du ratio saut tricks/saut sans tricks
        if(totalJumps > 0)
        {
            jumpRatio = totaljumpsWithTricks / totalJumps;
        }
        else
        {
            jumpRatio = 0;
        }

        var customProperties = new Dictionary<string, object>
        {
            {"Run Time in seconds", Mathf.FloorToInt(timer) },
            {"Rank", rank },
            //{"Skill Level", ER.CalculateSkillForThisGame() },
            //{"Skill Difference Compared to average", ER.CalculateSkillForThisGame() - ER.PlayerStats.averageSkillLevel },
            {"Number of jumps", totalJumps },
            {"Average number of tricks per jump", totalTrickNum/allTrickScores.Count },
            {"Average trick jump ratio", jumpRatio }
        };

        Amplitude.Instance.logEvent("Run Finished", customProperties);
     
    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            //app plus dans le background
            Amplitude.Instance.logEvent("Game Refocused");
        }
        else
        {
            //app passe en background
            //faire des trucs
            float skillDifference = ER.newAverageSkillLevel - averageSkillLevelAtStartOfSession;

            //mettre tous les trucs dans un dictionnaire
            var customProperties = new Dictionary<string, object>
        {
            {"Number of runs played", numberOfRuns },
            {"Time played in minutes", timer/60 },
            {"Average skill progression", skillDifference },
            {"Has seen credits?", hasSeenCredits },
            {"Has viewed options?", hasSeenOptions }
        };

            //logger dans un event
            Amplitude.Instance.logEvent("Session Ended", customProperties);

            //fermer la session Amplitude
            Amplitude.Instance.endSession();
        }
    }
}
