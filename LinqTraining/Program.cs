namespace LinqTraining
{
    internal class Program
    {


        static List<Clovek> Lidi = new List<Clovek>()
            {
                new Clovek("Adam","Sutner",23),
                new Clovek("Michal","Bílek",24),
                new Clovek("Petr","Florian",22),
                new Clovek("Martin","Tobořík",13),
                new Clovek("Vojtěch","Pokorný",282),
                new Clovek("Lucie","Pátková",30),
                new Clovek("Jonáš","Macoun",3),
                new Clovek("Filip","Malý",42),
            };

        static void Main(string[] args)
        {


            var Nezletilí = (from q in Lidi
                             where q.Zletily == false
                             select q).ToList();

            foreach (var u in Nezletilí)
                Console.WriteLine(u);


        }

    }
}
