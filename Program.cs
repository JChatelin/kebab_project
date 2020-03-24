using System;
using System.Collections.Generic;

namespace kebab_project
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> ingredients = new List<String>{"Pain", "Salade", "Tomate", "Oignons", "Fromage"};
            Kebab myKebabVegi = new Kebab(ingredients);
            Console.WriteLine("is vegi : " + myKebabVegi.isVegetarian());
            Kebab myKebabOnions = new Kebab(ingredients);
            Console.WriteLine("is withoutOnions : " + myKebabOnions.withOutOnions().getIngredients().Count);
            Kebab myKebabCheese = new Kebab(ingredients);
            Console.WriteLine("is suppCheese : " + myKebabCheese.supplementCheese().getIngredients().Count);
        }
    }

    public class Kebab {

        private List<String> ingredients;
        public Kebab(List<String> ingredients) {
            this.ingredients = ingredients;
        }

        public List<String> getIngredients() {
            return ingredients;
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

        public Kebab withOutOnions() {
            if(ingredients.Contains("Oignons")) {
                ingredients.Remove("Oignons");
            }
            return this;
        }

        private bool isCheese(String ingredient) {
            if(ingredient == "Fromage") {
                return true;
            } else {
                return false;
            }
        }
        public Kebab supplementCheese() {
            Predicate<String> cheese = new Predicate<string>(isCheese);
            int cheeseCount = 0;
            if(ingredients.Contains("Fromage")) {
                cheeseCount = ingredients.FindAll(cheese).Count;
                for(int i = 0; i < 2*cheeseCount; i++) {
                    ingredients.Add("Fromage");
                }
            } else {
                ingredients.Add("Fromage");    
            }
            return this;
        }
    }
}
