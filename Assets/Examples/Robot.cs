using UnityEngine;


// RPG is the main namespace for our game.
namespace RPG.Example
{
    public class Robot : MonoBehaviour
    {
        public int age = 5;
        public float price = 99.99f;
        //private string name = "McBot";
        public bool isTurnedOn = false;

        public Robot() 
        {
            isTurnedOn = true;
            float newPrice = CalculatePrice(0.1f, 1);

            if (newPrice > 75f) 
            {
                price = newPrice;
            } 
            else 
            {
                print("Price is too low.");
            }
        }

        public float CalculatePrice(float discount, int quantity) 
        {
            return (price - (price * discount)) * quantity;
        }
    }
    
}