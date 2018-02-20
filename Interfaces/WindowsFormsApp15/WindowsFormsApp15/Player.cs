using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    class Player
    {
        
        public string Name { get; set; }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.Name = name;
            random = new Random();
            cards = new Deck();
            this.textBoxOnForm = textBoxOnForm;
            this.textBoxOnForm.Text += Name + " has just joined the game\n";
            
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value==value)
                    {
                        howMany++;
                    }
                }
                if (howMany==4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;

        }

        public Values GetRandomValue()
        {
             return cards.Deal(random.Next(cards.Count)).Value;
        }

        public Deck DoYouHaveAny(Values value)
        {

        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock) { }
        public void AskForACard(List<Player> players,int myIndex,Deck stock,Values value) { }
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardName(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
