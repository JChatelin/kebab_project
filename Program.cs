using System;
using System.Collections.Generic;

namespace kebab_project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ingredients = new List<String>{"Pain", "Salade", "Tomate", "Oignons"};
            Kebab myKebab = new Kebab(ingredients);
            Console.WriteLine("is vegi : " + myKebab.isVegetarian());
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

        public void addSauce(String sauce) {
            if(!String.IsNullOrWhiteSpace(sauce)) {
                ingredients.Add(sauce);
            }
        }

    }
}
