namespace CG.BusinessLogic
{
    public class GameForm
    {
       
       public static CardDeck deckItems = new CardDeck();
        public void NolimitHolderPoker()
        {
            try
            {
                Console.WriteLine("How many player want to Play this game ?");
                Console.Write("1. One      \n2. Two      \n3. Three     \n4. Four  \n5. Five   \n6. Six    \n");

                int choice = int.Parse(Console.ReadLine());
                if (choice <= 6)
                    for (int i = 0; i < choice; i++)
                    {

                        Console.WriteLine(" Enter Name :");
                        string name = Console.ReadLine();

                        Deck mydeck = new Deck();

                        foreach (Card c in mydeck.Cards)
                        {
                            Console.WriteLine(c);
                        }
                        // throw new TableFullException(" Table are Full");
                    }
                else
                    throw new MoreThenSixPlayerNotAllowException(" Only 6 Seat are Available ");
            }
            catch (Exception ex) { throw; }
        }
        public void Rummy()
        {
            try
            {
                Console.WriteLine("How many player want to Play this game ?");
                Console.Write("1. One      \n2. Two      \n3. Three     \n4. Four  \n5. Five   \n6. Six    \n");

                int choice = int.Parse(Console.ReadLine());
                if (choice <= 6)
                    for (int i = 0; i < choice; i++)
                    {

                        Console.WriteLine(" Enter Name :");
                        string name = Console.ReadLine();

                        Deck mydeck = new Deck();

                        foreach (Card c in mydeck.Cards)
                        {
                            Console.WriteLine(c);
                        }
                    }
                else
                    throw new MoreThenSixPlayerNotAllowException(" Only 6 Seat are Available ");
            }
            catch (Exception ex) { throw; }
        }

        public void PotLimitOmaha()
        {
            try
            {
                Console.WriteLine("How many player want to Play this game ?");
                Console.Write("1. One      \n2. Two      \n3. Three     \n4. Four  \n5. Five   \n6. Six    \n");

                int choice = int.Parse(Console.ReadLine());
                if (choice <= 6)
                    for (int i = 0; i < choice; i++)
                    {

                        Console.WriteLine(" Enter Name :");
                        string name = Console.ReadLine();

                        Deck mydeck = new Deck();

                        foreach (Card c in mydeck.Cards)
                        {
                            Console.WriteLine(c);
                        }
                    }
                else
                    throw new MoreThenSixPlayerNotAllowException(" Only 6 Seat are Available ");
            }
            catch (Exception ex) { throw; }
        }

        public void ShortDeckPoker()
        {
            try
            {
                Console.WriteLine("How many player want to Play this game ?");
                Console.Write("1. One      \n2. Two      \n3. Three     \n4. Four  \n5. Five   \n6. Six    \n");

                int choice = int.Parse(Console.ReadLine());
                if (choice <= 6)
                    for (int i = 0; i < choice; i++)
                    {

                        Console.WriteLine(" Enter Name :");
                        string name = Console.ReadLine();

                        Deck mydeck = new Deck();

                        foreach (Card c in mydeck.Cards)
                        {
                            Console.WriteLine(c);
                        }
                    }
                else
                    throw new MoreThenSixPlayerNotAllowException(" Only 6 Seat are Available ");
            }
            catch (Exception ex) { throw; }
        }

        public void OpenFaceChinesePoker()
        {
            try
            {
                Console.WriteLine("How many player want to Play this game ?");
                Console.Write("1. One      \n2. Two      \n3. Three     \n4. Four  \n5. Five   \n6. Six    \n");

                int choice = int.Parse(Console.ReadLine());
                if (choice <= 6)
                    for (int i = 0; i < choice; i++)
                    {

                        Console.WriteLine(" Enter Name :");
                        string name = Console.ReadLine();

                        Deck mydeck = new Deck();

                        foreach (Card c in mydeck.Cards)
                        {
                            Console.WriteLine(c);
                        }
                    }
                else
                    throw new MoreThenSixPlayerNotAllowException(" Only 6 Seat are Available ");
            }
            catch (Exception ex) { throw; }
        }
    }
}




