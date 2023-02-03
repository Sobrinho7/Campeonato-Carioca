using static Campeonato.PlayMatch;

namespace CariocaSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> teams = new List<string> { "Flamengo", "Fluminense", "Vasco", "Botafogo" };
            Dictionary<string, int> scores = new Dictionary<string, int>();

            // Inicializa as pontuações dos times
            foreach (string team in teams)
            {
                scores[team] = 0;
            }

            // Primeira rodada
            Console.WriteLine("Primeira rodada");
            playMatch(teams[0], teams[1], scores);
            playMatch(teams[2], teams[3], scores);
            Console.WriteLine();

            // Segunda rodada
            Console.WriteLine("Segunda rodada");
            playMatch(teams[0], teams[2], scores);
            playMatch(teams[1], teams[3], scores);
            Console.WriteLine();

            // Terceira rodada
            Console.WriteLine("Terceira rodada");
            playMatch(teams[0], teams[3], scores);
            playMatch(teams[1], teams[2], scores);
            Console.WriteLine();

            // Ordena a tabela pelo número de pontos
            scores = scores.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            // Apresenta a tabela final
            Console.WriteLine();
            Console.WriteLine("Tabela final:");
            int position = 1;
            foreach (KeyValuePair<string, int> entry in scores)
            {
                Console.WriteLine(position + "º lugar: " + entry.Key + " com " + entry.Value + " pontos");
                position++;
            }
        }
    }
}
