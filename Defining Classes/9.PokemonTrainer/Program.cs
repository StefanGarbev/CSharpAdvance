namespace _9.PokemonTrainer;
public class StartUp
{
    public static void Main(string[] args)
    {
        List<Trainer> trainerPokemon = new List<Trainer>();
        string inputInfo = string.Empty;

        while (true)
        {
            inputInfo = Console.ReadLine();

            string[] input = inputInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = input[0];

            if (command == "Tournament")
            {
                break;
            }

            Trainer trainer = trainerPokemon.SingleOrDefault(t => t.Name == input[0]);

            if (trainer == null)
            {
                trainer.Name = input[0];
                trainer.pokemonCollerction.Add(new(input[1], input[2], int.Parse(input[3])));
                trainerPokemon.Add(trainer);
            }
            else
            {
                trainer.pokemonCollerction.Add(new(input[1], input[2], int.Parse(input[3])));
            }

            while (true)
            {
                string commandArg = Console.ReadLine();

                if (commandArg == "Fire")
                { 
                    trainerPokemon.Contains()
                }
            }
        }
    }
}      