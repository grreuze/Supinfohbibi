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
        AmplitudeHelper.AppId = "46acae4acfda355a0ed8a9c46d81007a";
        Amplitude.Instance.startSession();
        AmplitudeHelper.Instance.FillCustomProperties += FillTrackingProperties;

        //détection de l'heure de lancement de session et du modèle de téléphone
        var customProperties = new Dictionary<string, object>
        {
            {"Date", System.DateTime.UtcNow.ToString("HH:mm dd MMMM yyyy") },
            {"Device model", SystemInfo.deviceModel },
            {"Android Version", SystemInfo.operatingSystem }
        };

        AmplitudeHelper.Instance.LogEvent("Session Started", customProperties);

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
        AmplitudeHelper.Instance.LogEvent("Run Started");
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
       
        totalJumps++;      
    }

    public void FinishRun(float remainingTime, int rank)
    {
        //calcul du nombre moyen de tricks par saut
        float totalTrickNum = 0;

        for(int i = 0; i < allTrickScores.Count; i++)
        {
            totalTrickNum += allTrickScores[i];
        }

        //calcul du ratio saut tricks/saut sans tricks
        float jumpRatio = totaljumpsWithTricks / totalJumps;

        var customProperties = new Dictionary<string, object>
        {
            {"Remaining Time", remainingTime },
            {"Rank", rank },
            {"Skill Level", ER.CalculateSkillForThisGame() },
            {"Skill Difference Compared to average", ER.CalculateSkillForThisGame() - ER.PlayerStats.averageSkillLevel },
            {"Number of jumps", totalJumps },
            {"Average number of tricks per jump", totalTrickNum/allTrickScores.Count },
            {"Average trick jump ratio", jumpRatio }
        };

        AmplitudeHelper.Instance.LogEvent("Run Finished", customProperties);

        totalJumps = 0;
        totaljumpsWithTricks = 0;
    }

    //appelé quand le joueur quitte le jeu. Calcule pas mal de moyennes
    private void OnApplicationQuit()
    {
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
        AmplitudeHelper.Instance.LogEvent("Session Ended", customProperties);

        //fermer la session Amplitude
        Amplitude.Instance.endSession();
    }
}
