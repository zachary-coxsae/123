using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{
    public static Action<ObstacleHealth> OnObstacleDestroyed; //follow week 8 slides page 12
    public static Action<LoseCondition> OnLoseCondition;
}
