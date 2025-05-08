using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Entities
{

    public class Player : MonoBehaviour
    {
        public string playerName;
        private int health;
        private readonly int randomThing;

        public int Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }
        }

        public Player(string playerName, int health)
        {
            this.playerName = playerName;
            this.health = health;

            randomThing = 25;


        }

        public void PrintStats()
        {

            Debug.Log(playerName + " " + health);
            Debug.Log(randomThing);
        }
    }

}



