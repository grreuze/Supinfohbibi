using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class EndRun : MonoBehaviour {

    private GameManager _gameManager;

    public Stats PlayerStats;

    public float remainingTimeInSeconds;
    public float ratioOfCollectiblesFound;
    //public float timeToBeat;

    //niveau de skill moyen des parties
    public float newAverageSkillLevel;

    private void Awake()
    {
        _gameManager = GameManager.GetInstance();
    }

    //méthode qui va calculer la difficulté de la run
    public void OnRunStart()
    {
        if (!Directory.Exists("Saves"))
        {
            Directory.CreateDirectory("Saves");
        }
        if (!File.Exists("Saves/statistics.jpp"))
        {
            PlayerStats.AllSkillLevels = 0;
            PlayerStats.bestScore = 0;
            PlayerStats.totalRunsCount = 0;
            PlayerStats.averageSkillLevel = 0;
            SaveData();
        }
        LoadData();

        //Formules à implémenter et à tester
        //runLength = Random.Range(20, 30);
        //timeToBeat = (LevelGeneration.ins.runLength*10)+((1-PlayerStats.averageSkillLevel) * 12);
    }
	

    public void LaunchEndRunProtocol()
    {
        //TODO calculer le ratio de collectables ramassés

        //on attribue toutes les stats nécessaires à sauvegarder
        PlayerStats.totalRunsCount++;
        PlayerStats.AllSkillLevels += CalculateSkillForThisGame();

        CalculateAverageSkillLevel();

        PlayerStats.averageSkillLevel = newAverageSkillLevel;
        PlayerStats.totalCoins = _gameManager.coins;
        PlayerStats.bestScore = _gameManager.GetBestScore();
        Metrics.GetInstance().FinishRun(FindObjectOfType<Ranking>().GetRank());

        PlayerStats.totalCoins += _gameManager.coins;

        SaveData();
    }

    public void SaveData()
    {
 
        PlayerPrefs.SetInt("Best Score", PlayerStats.bestScore);
        PlayerPrefs.SetFloat("Average Skill Level", PlayerStats.averageSkillLevel);

        if (PlayerPrefs.HasKey("All Skill Levels"))
            PlayerPrefs.SetFloat("All Skill Levels", PlayerPrefs.GetFloat("All Skill Levels") + CalculateSkillForThisGame());
        else PlayerPrefs.SetFloat("All Skill Levels", CalculateSkillForThisGame());
    
        PlayerPrefs.SetInt("Total Runs Count", PlayerStats.totalRunsCount);
        PlayerPrefs.SetInt("All Coins", PlayerStats.totalCoins);
       
        PlayerPrefs.Save();

    }

    public void LoadData()
    {
        PlayerStats.bestScore = PlayerPrefs.GetInt("Best Score");
        PlayerStats.averageSkillLevel = PlayerPrefs.GetFloat("Average Skill Level");
        PlayerStats.totalRunsCount = PlayerPrefs.GetInt("Total Runs Count");
        PlayerStats.AllSkillLevels = PlayerPrefs.GetFloat("All Skill Levels");
        PlayerStats.totalCoins = PlayerPrefs.GetInt("All Coins");
        _gameManager.coins = PlayerStats.totalCoins;

    }
    
    private void CalculateAverageSkillLevel()
    {
        newAverageSkillLevel = PlayerStats.AllSkillLevels / PlayerStats.totalRunsCount;
    }

    //calcule le taux de skill de la game (à lancer juste avant la save)
    public float CalculateSkillForThisGame()
    {
        float skill = (0.18f * remainingTimeInSeconds) * ratioOfCollectiblesFound;

        return skill;
    }
}

//classe qui contient toutes les données sauvegardables
[System.Serializable]
public class Stats
{
    public int totalRunsCount;

    public float averageSkillLevel;

    public int bestScore;

    public float AllSkillLevels;

    public int totalCoins;

}
