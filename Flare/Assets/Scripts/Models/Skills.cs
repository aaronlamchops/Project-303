using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour {

    int enemiesKilled;
    int level;
    string skillName;

    Skill(string skill)
    {
        enemiesKilled = 0;
        level = 0;
        skillName = skill;
    }
}
