using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnturnedBOM.Model
{
    public static class Crafting
    {
        private static readonly Dictionary<string, Item> Items = new Dictionary<string, Item>();
        private static readonly Dictionary<string, Recipe> Recipes = new Dictionary<string, Recipe>();

        public enum Tools { None, Handsaw, Fire, Pocketknife };

        public static bool AddItem(Item item)
        {
            bool success = false;
            if (item != null && !Items.ContainsKey(item.Name))
            {
                Items.Add(item.Name, item);
                success = true;
            }
            return success;
        }

        public static int AddItems(ItemData items)
        {
            int count = 0;
            foreach (Item item in items.Items)
            {
                if (AddItem(item))
                    count++;
            }
            return count;
        }

        public static Item GetItem(string itemName)
        {
            return DeepCopy.Copy<Item>(Items[itemName]);
        }

        public static bool AddRecipe(Recipe recipe)
        {
            bool success = false;
            if (recipe != null && !Recipes.ContainsKey(recipe.Name))
            {
                Recipes.Add(recipe.Name, recipe);
                success = true;
            }
            return success;
        }

        public static int AddRecipes(RecipeData recipes)
        {
            int count = 0;
            foreach (Recipe recipe in recipes.Recipes)
            {
                if (AddRecipe(recipe))
                    count++;
            }
            return count;
        }

        public static Recipe GetRecipe(string recipeName)
        {
            return DeepCopy.Copy<Recipe>(Recipes[recipeName]);
        }

    }
}
