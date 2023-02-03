namespace Campeonato

{
    class PlayMatch
    {
        public static void playMatch(string teamA, string teamB, Dictionary<string, int> scores)
        {
            Console.WriteLine("Jogo entre " + teamA + " e " + teamB);
            Console.WriteLine("Digite 1 para vitória de " + teamA + ", 2 para vitória de " + teamB + " ou 0 para empate:");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == 1)
            {
                scores[teamA] += 3;
            }
            else if (result == 2)
            {
                scores[teamB] += 3;
            }
            else
            {
                scores[teamA]++;
                scores[teamB]++;
            }
            Console.ReadLine();
        }
    }
}
