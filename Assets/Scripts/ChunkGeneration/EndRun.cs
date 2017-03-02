﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class EndRun : MonoBehaviour {

    public Stats PlayerStats = new Stats();

    public float remainingTimeInSeconds;
    public float ratioOfCollectiblesFound;

    //niveau de skill moyen des parties
    float newAverageSkillLevel;
    
    //méthode qui va calculer la difficulté de la run
    public void OnRunStart()
    {
        LoadData();

        //Formules à implémenter et à tester
        //runLength = Random.Range(20, 30);
        //timeToBeat = (RunLength*10)+((1-Playerstats.averageSkillLevel) * 12);
    }
	

    public void LaunchEndRunProtocol()
    {
        //TODO calculer le ratio de collectables ramassés

        //on attribue toutes les stats nécessaires à sauvegarder
        PlayerStats.totalRunsCount++;
        PlayerStats.AllSkillLevels.Add(CalculateSkillForThisGame());

        CalculateAverageSkillLevel();

        PlayerStats.averageSkillLevel = newAverageSkillLevel;

        SaveData();
    }

    public void SaveData()
    {
        if (!Directory.Exists("Saves"))       
            Directory.CreateDirectory("Saves");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream Savefile = File.Create("Saves/statistics.jpp");

        formatter.Serialize(Savefile, PlayerStats);
        Savefile.Close();
    }

    public void LoadData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream SaveFile = File.Open("Saves/statistics.jpp", FileMode.Open);

        PlayerStats = (Stats)formatter.Deserialize(SaveFile);
        SaveFile.Close();
    }
    
    private void CalculateAverageSkillLevel()
    {
        float totalSkill = 0;

        for(int i = 0; i < PlayerStats.AllSkillLevels.Count; i++)
        {
            totalSkill += PlayerStats.AllSkillLevels[i];
        }

        newAverageSkillLevel = totalSkill / PlayerStats.AllSkillLevels.Count;
    }

    //calcule le taux de skill de la game (à lancer juste avant la save)
    private float CalculateSkillForThisGame()
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

    public List<float> AllSkillLevels;

}
