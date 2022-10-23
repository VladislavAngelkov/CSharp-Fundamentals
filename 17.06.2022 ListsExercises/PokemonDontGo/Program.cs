using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int removedElementsSum = 0;
            while (pokemons.Count>0)
            {
                int indexOfPokemon = int.Parse(Console.ReadLine());
                if (indexOfPokemon < 0)
                {
                    int removedPokemon = pokemons[0];
                    removedElementsSum += removedPokemon;
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i]<=removedPokemon)
                        {
                            pokemons[i] += removedPokemon;
                        }
                        else
                        {
                            pokemons[i] -= removedPokemon;
                        }
                    }
                }
                else if (indexOfPokemon>=pokemons.Count)
                {
                    int removedPokemon = pokemons[pokemons.Count-1];
                    removedElementsSum += removedPokemon;
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removedPokemon)
                        {
                            pokemons[i] += removedPokemon;
                        }
                        else
                        {
                            pokemons[i] -= removedPokemon;
                        }
                    }
                }
                else
                {
                    int removedPokemon = pokemons[indexOfPokemon];
                    pokemons.RemoveAt(indexOfPokemon);
                    removedElementsSum += removedPokemon;
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removedPokemon)
                        {
                            pokemons[i] += removedPokemon;
                        }
                        else
                        {
                            pokemons[i] -= removedPokemon;
                        }
                    }
                }
            }
            Console.WriteLine(removedElementsSum);
        }
    }
}
