namespace BusinessCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ascii = """
     _____                   _                    _              
    |  __ \                 | |        /\        | |             
    | |  | | ___  _ __ _   _| | __    /  \   _ __| |_ _   _  ___ 
    | |  | |/ _ \| '__| | | | |/ /   / /\ \ | '__| __| | | |/ __|
    | |__| | (_) | |  | |_| |   <   / ____ \| |  | |_| |_| | (__ 
    |_____/ \___/|_|   \__,_|_|\_\ /_/    \_\_|   \__|\__,_|\___|

    """;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(ascii);
            Console.ResetColor();
            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("| Opleiding: Graduaat programmeren  |");
            Console.WriteLine("| Klas: 1PROD                       |");
            Console.WriteLine("| Favoriete taal: C#                |");
            Console.WriteLine("+-----------------------------------+");
        }
    }
}
