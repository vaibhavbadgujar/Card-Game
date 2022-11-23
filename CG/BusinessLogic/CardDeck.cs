using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.BusinessLogic;

public class CardDeck
{
    
    
    private List<String> deckItems = new List<string>();
    private void Add()
    {
        deckItems.AddRange(new[]
                               {
                                           "♣ King", "♣ Queen", "♣ Jack", " ♣ Ace", "♣ 1", "♣ 2", "♣ 3", "♣ 4", "♣ 5", "♣ 6", "♣ 7", "♣ 8", "♣ 9", "♣ 10",
                                           "♦ King", "♦ Queen", "♦ Jack", " ♦ Ace", "♦ 1", "♦ 2", "♦ 3", "♦ 4", "♦ 5", "♦ 6", "♦ 7", "♦ 8", "♦ 9", "♦ 10",
                                           "♥ King", "♥ Queen", "♥ Jack", " ♥ Ace", "♥ 1", "♥ 2", "♥ 3", "♥ 4", "♥ 5", "♥ 6", "♥ 7", "♥ 8", "♥ 9", "♥ 10",
                                           "♠ King", "♠ Queen", "♠ Jack", " ♠ Ace", "♠ 1", "♠ 2", "♠ 3", "♠ 4", "♠ 5", "♠ 6", "♠ 7", "♠ 8", "♠ 9", "♠ 10"  });


    }

    private String Draw()
    {
        if (deckItems == null || deckItems.Count == 0)
            throw new Exception("All cards are drawn.");
        var rnd = new Random();
        var i = rnd.Next(0, deckItems.Count() - 1);
        var val = deckItems[i];
        deckItems.RemoveAt(i);
        return val;







    //public List<String> deckItems = new List<string>();

    //public Random rand = new Random();


    //public void Add()
    //{
    //    deckItems.AddRange(new[]
    //    {
    //                                   "♣ King", "♣ Queen", "♣ Jack", " ♣ Ace", "♣ 1", "♣ 2", "♣ 3", "♣ 4", "♣ 5", "♣ 6", "♣ 7", "♣ 8", "♣ 9", "♣ 10",
    //                                   "♦ King", "♦ Queen", "♦ Jack", " ♦ Ace", "♦ 1", "♦ 2", "♦ 3", "♦ 4", "♦ 5", "♦ 6", "♦ 7", "♦ 8", "♦ 9", "♦ 10",
    //                                   "♥ King", "♥ Queen", "♥ Jack", " ♥ Ace", "♥ 1", "♥ 2", "♥ 3", "♥ 4", "♥ 5", "♥ 6", "♥ 7", "♥ 8", "♥ 9", "♥ 10",
    //                                   "♠ King", "♠ Queen", "♠ Jack", " ♠ Ace", "♠ 1", "♠ 2", "♠ 3", "♠ 4", "♠ 5", "♠ 6", "♠ 7", "♠ 8", "♠ 9", "♠ 10"
    //                 });
    //}

    //public static int[] Shuffle(int[] deck)
    //{
    //    int[] shuffled = new int[deck.Length];
    //    shuffled[0] = deck[0];
    //    for (int i = 1; i < deck.Length; i++)
    //    {
    //        int j = Rand.Next(i + 1);
    //        if (j != i)
    //            shuffled[i] = shuffled[j];
    //        shuffled[j] = deck[i];
    //    }
    //    return shuffled;
    //    //}


   
    }
}


