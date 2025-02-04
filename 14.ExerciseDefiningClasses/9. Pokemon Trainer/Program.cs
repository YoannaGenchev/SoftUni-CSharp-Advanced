namespace _9._Pokemon_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> name = new Dictionary<string, Trainer>();

            string command = Console.ReadLine();
            while (command != "Tournament")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string trainerName = commandArgs[0];
                if (!name.ContainsKey(trainerName))
                    name[trainerName] = new Trainer(trainerName);

                Trainer trainer = name[trainerName];
                Pokemon pokemon = new Pokemon(commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]));

                trainer.Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "End")
            {
                foreach (Trainer trainer in name.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command)) trainer.Badges++;
                    else
                    {
                        for (int i = trainer.Pokemons.Count - 1; i >= 0; i--)
                        {
                            if (trainer.Pokemons[i].Health <= 10) trainer.Pokemons.RemoveAt(i);
                            else trainer.Pokemons[i].Health -= 10;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (Trainer trainer in name.Values.OrderByDescending(t => t.Badges))
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }
    
}
