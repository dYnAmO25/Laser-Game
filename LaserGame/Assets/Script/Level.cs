using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level
{
    //Ground
    public int iX;
    public int iZ;

    //Player
    public float fXP;
    public float fZP;

    //Blocks
    public float[] position;

    //Goals
    public float[] goalsPosition;

    //Blue Laser
    public float[] blueLaser;

    //Red Laser
    public float[] redLaser;
}
