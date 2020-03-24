using System;
using System.Collections.Generic;

namespace kebab_project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ingredients = new List<String>{"Pain", "Salade", "Tomate"};
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
            if(ingredients.Contains("Poulet") || ingredients.Contains("Viande")) {
                return false;
            } else {
                return true;
            }
        }
    }
}
