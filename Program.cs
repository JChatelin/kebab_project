using System;
using System.Collections.Generic;

namespace kebab_project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ingredients = new List<String>{"Pain", "Salade", "Tomate", "Oignons"};
            Kebab myKebabVegi = new Kebab(ingredients);
            Console.WriteLine("is vegi : " + myKebabVegi.isVegetarian());
            ingredients.Add("Crevette");
            Kebab myKebabPesce = new Kebab(ingredients);
            Console.WriteLine("is pesce : " + myKebabPesce.isVegetarian());
            
        }
    }

    public class Kebab {

        private List<String> ingredients;
        public Kebab(List<String> ingredients) {
            this.ingredients = ingredients;
        }

        public bool isVegetarian() {
            if(ingredients.Contains("Poulet") || ingredients.Contains("Viande") 
            || ingredients.Contains("Poisson") || ingredients.Contains("Crevettes")) {
                return false;
            } else {
                return true;
            }
        }

        public bool isPescotarian() {
            if(ingredients.Contains("Poisson") || ingredients.Contains("Crevettes")) {
                return true;
            } else {
                return false;
            }
        }
    }
}
