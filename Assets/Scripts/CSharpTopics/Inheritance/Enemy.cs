using System.Collections.Generic;
using Unity.VisualScripting;

namespace Assets.Scripts.Entities.Inheritance
{
    // Enemy is a Character
    public class Enemy : Character
    {
        // private int[] cardNumberList;
        private List<int> cardNumberList;

        public List<int> CardNumberList
        {

            get { return cardNumberList; }
            set { cardNumberList = value; }


        }

        public Enemy(List<int> cardNumberList, string name, int health) : base(name, health)
        {

            this.cardNumberList = cardNumberList;

        }


    }

}