namespace HelloBSG
{
    internal class Me
    {
        public static void PrintAboutMe(Dictionary<string, string[]> info)
        {
            Console.SetCursorPosition((Console.WindowWidth - "ABOUT ME".Length) / 2, Console.CursorTop);
            Console.WriteLine("ABOUT ME");

            foreach (var pair in info)
            {
                Console.Write($"\n\n{pair.Key}: ");

                if (pair.Value.Length < 2)
                {
                    Console.Write(pair.Value.Length > 0 ? pair.Value[0] : throw new Exception($"The values list of info empty. \n\t Pair key: {pair.Key}"));
                    continue;
                }
                for (int i = 0; i < pair.Value.Length; i++)
                {
                    char endingChar = i == pair.Value.Length - 1 ? '.' : ',';
                    Console.Write($"\n\t{pair.Value[i]}{endingChar} ");
                }
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string[]> info = new Dictionary<string, string[]>()
            {
                {"Personal info", new[] {"Simonov Artem",  "16 years old", "Studying in 10th class", "Living in Moscow" } },
                {"My hobbies", new[] {"Guitar", "Programming"} },
                { "Programming practice", new[] { "5 years" } },
                { "My links", new[] { "Summary: https://hh.ru/applicant/resumes/view?resume=df7a94c9ff0bbda55a0039ed1f4e4431354868", "GitHub: https://github.com/Ninthchain" } }
            };

            PrintAboutMe(info);
        }
    }
}