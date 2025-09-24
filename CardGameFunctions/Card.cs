using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cards2;

public class Card
{
    //Fields, example: Rank rank;
    //check the help documentation for the fields
    private Rank rank;
    private Suit suit;
    private bool faceUp;



    //Card Constructor
    public Card(Rank rank, Suit suit, bool faceUp = true)
    {
        this.rank = rank;
        this.suit = suit;
        this.faceUp = faceUp;
    }


    //Define properties for all above fields
    //code example: public Suit Suit { get { return suit; } }
    public Rank Rank { get { return rank; } }
    public Suit Suit { get { return suit; } }
    public bool FaceUp { get { return faceUp; } }



    public void FlipOver()
    {
        faceUp = !faceUp;
        //implementation 
    }
    public override string ToString()
    {
        if (faceUp)
        {
            return $"{rank} of {suit}";
        }
        else
        {
            return "Face-down card";
        }
    }

}
