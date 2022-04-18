using System;
using System.Drawing;
using System.Windows.Forms;


namespace _21_Card_Trick
{
    public partial class pbxMain_Trick : Form
    {
        string[,,] cardArray = new string[4, 3, 7];
        char selection1;
        char selection2;
        char selection3;
        int clickCounter;
        public const string imagePath = @"C:\Users\jason\Documents\Courses\MSSA\MCAD1\Projects\21-Card AI Trick\WinForms App\21 Card Trick\Resources\";

        public pbxMain_Trick()
        {
            InitializeComponent();
        }

        private void Main_Trick_Load(object sender, EventArgs e)
        {
            clickCounter = 0;
        }

        public void BtnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        #region Start Method
        public void Start()
        {
            #region Single-Dimension Array to Build Card Deck(54 cards)
            string[] fullDeck = new string[]
            {
                "Spades_02", "Spades_03", "Spades_04", "Spades_05", "Spades_06", "Spades_07", "Spades_08", "Spades_09", "Spades_10", "Spades_J", "Spades_Q", "Spades_K", "Spades_A",
                "Hearts_02", "Hearts_03", "Hearts_04", "Hearts_05", "Hearts_06", "Hearts_07", "Hearts_08", "Hearts_09", "Hearts_10", "Hearts_J", "Hearts_Q", "Hearts_K", "Hearts_A",
                "Diamonds_02", "Diamonds_03", "Diamonds_04", "Diamonds_05", "Diamonds_06", "Diamonds_07", "Diamonds_08", "Diamonds_09", "Diamonds_10", "Diamonds_J", "Diamonds_Q", "Diamonds_K", "Diamonds_A",
                "Clubs_02", "Clubs_03", "Clubs_04", "Clubs_05", "Clubs_06", "Clubs_07", "Clubs_08", "Clubs_09", "Clubs_10", "Clubs_J", "Clubs_Q", "Clubs_K", "Clubs_A", "Joker_Black", "Joker_Red"
            };
            #endregion

            #region Random Selection of 21 Cards
            if (clickCounter == 0)
            {
                Random pick = new Random();
                int card01 = pick.Next(fullDeck.Length);
                int card02 = pick.Next(fullDeck.Length);
                while (card02 == card01)
                {
                    card02 = pick.Next(fullDeck.Length);
                }
                int card03 = pick.Next(fullDeck.Length);
                while (card03 == card01 || card03 == card02)
                {
                    card03 = pick.Next(fullDeck.Length);
                }
                int card04 = pick.Next(fullDeck.Length);
                while (card04 == card01 || card04 == card02 || card04 == card03)
                {
                    card04 = pick.Next(fullDeck.Length);
                }
                int card05 = pick.Next(fullDeck.Length);
                while (card05 == card01 || card05 == card02 || card05 == card03 || card05 == card04)
                {
                    card05 = pick.Next(fullDeck.Length);
                }
                int card06 = pick.Next(fullDeck.Length);
                while (card06 == card01 || card06 == card02 || card06 == card03 || card06 == card04 || card06 == card05)
                {
                    card06 = pick.Next(fullDeck.Length);
                }
                int card07 = pick.Next(fullDeck.Length);
                while (card07 == card01 || card07 == card02 || card07 == card03 || card07 == card04 || card07 == card05 || card07 == card06)
                {
                    card07 = pick.Next(fullDeck.Length);
                }
                int card08 = pick.Next(fullDeck.Length);
                while (card08 == card01 || card08 == card02 || card08 == card03 || card08 == card04 || card08 == card05 || card08 == card06 || card08 == card07)
                {
                    card08 = pick.Next(fullDeck.Length);
                }
                int card09 = pick.Next(fullDeck.Length);
                while (card09 == card01 || card09 == card02 || card09 == card03 || card09 == card04 || card09 == card05 || card09 == card06 || card09 == card07 || card09 == card08)
                {
                    card09 = pick.Next(fullDeck.Length);
                }
                int card10 = pick.Next(fullDeck.Length);
                while (card10 == card01 || card10 == card02 || card10 == card03 || card10 == card04 || card10 == card05 || card10 == card06 || card10 == card07 || card10 == card08 || card10 == card09)
                {
                    card10 = pick.Next(fullDeck.Length);
                }
                int card11 = pick.Next(fullDeck.Length);
                while (card11 == card01 || card11 == card02 || card11 == card03 || card11 == card04 || card11 == card05 || card11 == card06 || card11 == card07 || card11 == card08 || card11 == card09 || card11 == card10)
                {
                    card11 = pick.Next(fullDeck.Length);
                }
                int card12 = pick.Next(fullDeck.Length);
                while (card12 == card01 || card12 == card02 || card12 == card03 || card12 == card04 || card12 == card05 || card12 == card06 || card12 == card07 || card12 == card08 || card12 == card09 || card12 == card10 || card12 == card11)
                {
                    card12 = pick.Next(fullDeck.Length);
                }
                int card13 = pick.Next(fullDeck.Length);
                while (card13 == card01 || card13 == card02 || card13 == card03 || card13 == card04 || card13 == card05 || card13 == card06 || card13 == card07 || card13 == card08 || card13 == card09 || card13 == card10 || card13 == card11 || card13 == card12)
                {
                    card13 = pick.Next(fullDeck.Length);
                }
                int card14 = pick.Next(fullDeck.Length);
                while (card14 == card01 || card14 == card02 || card14 == card03 || card14 == card04 || card14 == card05 || card14 == card06 || card14 == card07 || card14 == card08 || card14 == card09 || card14 == card10 || card14 == card11 || card14 == card12 || card14 == card13)
                {
                    card14 = pick.Next(fullDeck.Length);
                }
                int card15 = pick.Next(fullDeck.Length);
                while (card15 == card01 || card15 == card02 || card15 == card03 || card15 == card04 || card15 == card05 || card15 == card06 || card15 == card07 || card15 == card08 || card15 == card09 || card15 == card10 || card15 == card11 || card15 == card12 || card15 == card13 || card15 == card14)
                {
                    card15 = pick.Next(fullDeck.Length);
                }
                int card16 = pick.Next(fullDeck.Length);
                while (card16 == card01 || card16 == card02 || card16 == card03 || card16 == card04 || card16 == card05 || card16 == card06 || card16 == card07 || card16 == card08 || card16 == card09 || card16 == card10 || card16 == card11 || card16 == card12 || card16 == card13 || card16 == card14 || card16 == card15)
                {
                    card16 = pick.Next(fullDeck.Length);
                }
                int card17 = pick.Next(fullDeck.Length);
                while (card17 == card01 || card17 == card02 || card17 == card03 || card17 == card04 || card17 == card05 || card17 == card06 || card17 == card07 || card17 == card08 || card17 == card09 || card17 == card10 || card17 == card11 || card17 == card12 || card17 == card13 || card17 == card14 || card17 == card15 || card17 == card16)
                {
                    card17 = pick.Next(fullDeck.Length);
                }
                int card18 = pick.Next(fullDeck.Length);
                while (card18 == card01 || card18 == card02 || card18 == card03 || card18 == card04 || card18 == card05 || card18 == card06 || card18 == card07 || card18 == card08 || card18 == card09 || card18 == card10 || card18 == card11 || card18 == card12 || card18 == card13 || card18 == card14 || card18 == card15 || card18 == card16 || card18 == card17)
                {
                    card18 = pick.Next(fullDeck.Length);
                }
                int card19 = pick.Next(fullDeck.Length);
                while (card19 == card01 || card19 == card02 || card19 == card03 || card19 == card04 || card19 == card05 || card19 == card06 || card19 == card07 || card19 == card08 || card19 == card09 || card19 == card10 || card19 == card11 || card19 == card12 || card19 == card13 || card19 == card14 || card19 == card15 || card19 == card16 || card19 == card17 || card19 == card18)
                {
                    card19 = pick.Next(fullDeck.Length);
                }
                int card20 = pick.Next(fullDeck.Length);
                while (card20 == card01 || card20 == card02 || card20 == card03 || card20 == card04 || card20 == card05 || card20 == card06 || card20 == card07 || card20 == card08 || card20 == card09 || card20 == card10 || card20 == card11 || card20 == card12 || card20 == card13 || card20 == card14 || card20 == card15 || card20 == card16 || card20 == card17 || card20 == card18 || card20 == card19)
                {
                    card20 = pick.Next(fullDeck.Length);
                }
                int card21 = pick.Next(fullDeck.Length);
                while (card21 == card01 || card21 == card02 || card21 == card03 || card21 == card04 || card21 == card05 || card21 == card06 || card21 == card07 || card21 == card08 || card21 == card09 || card21 == card10 || card21 == card11 || card21 == card12 || card21 == card13 || card21 == card14 || card21 == card15 || card21 == card16 || card21 == card17 || card21 == card18 || card21 == card19 || card21 == card20)
                {
                    card21 = pick.Next(fullDeck.Length);
                }
                #endregion

                #region 21 randomly picked cards assigned to 3D array at subset [0]

                string[,,] superArray = new string[4, 3, 7]
                {
                {
                    {fullDeck[card01], fullDeck[card02], fullDeck[card03], fullDeck[card04], fullDeck[card05], fullDeck[card06], fullDeck[card07]}, // row A0 [0][0][0] - [0][0][6]
                    {fullDeck[card08], fullDeck[card09], fullDeck[card10], fullDeck[card11], fullDeck[card12], fullDeck[card13], fullDeck[card14]}, // row B0 [0][1][0] - [0][1][6]
                    {fullDeck[card15], fullDeck[card16], fullDeck[card17], fullDeck[card18], fullDeck[card19], fullDeck[card20], fullDeck[card21]}, // row C0 [0][2][0] - [0][2][6]
                },
                {
                    { "void", "void", "void", "void", "void", "void", "void"}, // row A1 [1][0][0] - [1][0][6]
                    { "void", "void", "void", "void", "void", "void", "void"}, // row B1 [1][1][0] - [1][1][6]
                    { "void", "void", "void", "void", "void", "void", "void"}, // row C1 [1][2][0] - [1][2][6]
                },
                {
                    { "void", "void", "void", "void", "void", "void", "void"}, // row A2 [2][0][0] - [2][0][6]
                    { "void", "void", "void", "void", "void", "void", "void"}, // row B2 [2][1][0] - [2][1][6]
                    { "void", "void", "void", "void", "void", "void", "void"}, // row C2 [2][2][0] - [2][2][6]
                },
                {
                    { "void", "void", "void", "void", "void", "void", "void"}, // row A3 [3][0][0] - [3][0][6]
                    { "void", "void", "void", "void", "void", "void", "void"}, // row B3 [3][1][0] - [3][1][6]
                    { "void", "void", "void", "void", "void", "void", "void"}, // row C3 [3][2][0] - [3][2][6]
                }
                };
                Array.Copy(superArray, cardArray, 84);
                DealCards(ref cardArray);
                #endregion
            }

            #region Selection 1
            else if (clickCounter == 1 && selection1 == 'A')
            {
                // row A1
                cardArray[1, 0, 0] = cardArray[0, 2, 6]; //card21
                cardArray[1, 0, 1] = cardArray[0, 2, 3]; //card18
                cardArray[1, 0, 2] = cardArray[0, 2, 0]; //card15
                cardArray[1, 0, 3] = cardArray[0, 0, 4]; //card05
                cardArray[1, 0, 4] = cardArray[0, 0, 1]; //card02
                cardArray[1, 0, 5] = cardArray[0, 1, 5]; //card13
                cardArray[1, 0, 6] = cardArray[0, 1, 2]; //card10
                // row B1
                cardArray[1, 1, 0] = cardArray[0, 2, 5]; //card20
                cardArray[1, 1, 1] = cardArray[0, 2, 2]; //card17
                cardArray[1, 1, 2] = cardArray[0, 0, 6]; //card07
                cardArray[1, 1, 3] = cardArray[0, 0, 3]; //card04
                cardArray[1, 1, 4] = cardArray[0, 0, 0]; //card01
                cardArray[1, 1, 5] = cardArray[0, 1, 4]; //card12
                cardArray[1, 1, 6] = cardArray[0, 1, 1]; //card09
                // row C1
                cardArray[1, 2, 0] = cardArray[0, 2, 4]; //card19
                cardArray[1, 2, 1] = cardArray[0, 2, 1]; //card16
                cardArray[1, 2, 2] = cardArray[0, 0, 5]; //card06
                cardArray[1, 2, 3] = cardArray[0, 0, 2]; //card03
                cardArray[1, 2, 4] = cardArray[0, 1, 6]; //card14
                cardArray[1, 2, 5] = cardArray[0, 1, 3]; //card11
                cardArray[1, 2, 6] = cardArray[0, 1, 0]; //card08

                DisplaySort1(ref cardArray);
            }
            else if (clickCounter == 1 && selection1 == 'B')
            {
                // row A1
                cardArray[1, 0, 0] = cardArray[0, 2, 6]; //card21
                cardArray[1, 0, 1] = cardArray[0, 2, 3]; //card18
                cardArray[1, 0, 2] = cardArray[0, 2, 0]; //card15
                cardArray[1, 0, 3] = cardArray[0, 1, 4]; //card12
                cardArray[1, 0, 4] = cardArray[0, 1, 1]; //card09
                cardArray[1, 0, 5] = cardArray[0, 0, 5]; //card06
                cardArray[1, 0, 6] = cardArray[0, 0, 2]; //card03
                // row B1
                cardArray[1, 1, 0] = cardArray[0, 2, 5]; //card20
                cardArray[1, 1, 1] = cardArray[0, 2, 2]; //card17
                cardArray[1, 1, 2] = cardArray[0, 1, 6]; //card14
                cardArray[1, 1, 3] = cardArray[0, 1, 3]; //card11
                cardArray[1, 1, 4] = cardArray[0, 1, 0]; //card08
                cardArray[1, 1, 5] = cardArray[0, 0, 4]; //card05
                cardArray[1, 1, 6] = cardArray[0, 0, 1]; //card02
                // row C1
                cardArray[1, 2, 0] = cardArray[0, 2, 4]; //card19
                cardArray[1, 2, 1] = cardArray[0, 2, 1]; //card16
                cardArray[1, 2, 2] = cardArray[0, 1, 5]; //card13
                cardArray[1, 2, 3] = cardArray[0, 1, 2]; //card10
                cardArray[1, 2, 4] = cardArray[0, 0, 6]; //card07
                cardArray[1, 2, 5] = cardArray[0, 0, 3]; //card04
                cardArray[1, 2, 6] = cardArray[0, 0, 0]; //card01

                DisplaySort1(ref cardArray);
            }
            else if (clickCounter == 1 && selection1 == 'C')
            {
                // row A1
                cardArray[1, 0, 0] = cardArray[0, 1, 6]; //card14
                cardArray[1, 0, 1] = cardArray[0, 1, 3]; //card11
                cardArray[1, 0, 2] = cardArray[0, 1, 0]; //card08
                cardArray[1, 0, 3] = cardArray[0, 2, 4]; //card19
                cardArray[1, 0, 4] = cardArray[0, 2, 1]; //card16
                cardArray[1, 0, 5] = cardArray[0, 0, 5]; //card06
                cardArray[1, 0, 6] = cardArray[0, 0, 2]; //card03
                // row B1
                cardArray[1, 1, 0] = cardArray[0, 1, 5]; //card13
                cardArray[1, 1, 1] = cardArray[0, 1, 2]; //card10
                cardArray[1, 1, 2] = cardArray[0, 2, 6]; //card21
                cardArray[1, 1, 3] = cardArray[0, 2, 3]; //card18
                cardArray[1, 1, 4] = cardArray[0, 2, 0]; //card15
                cardArray[1, 1, 5] = cardArray[0, 0, 4]; //card05
                cardArray[1, 1, 6] = cardArray[0, 0, 1]; //card02
                // row C1
                cardArray[1, 2, 0] = cardArray[0, 1, 4]; //card12
                cardArray[1, 2, 1] = cardArray[0, 1, 1]; //card09
                cardArray[1, 2, 2] = cardArray[0, 2, 5]; //card20
                cardArray[1, 2, 3] = cardArray[0, 2, 2]; //card17
                cardArray[1, 2, 4] = cardArray[0, 0, 6]; //card07
                cardArray[1, 2, 5] = cardArray[0, 0, 3]; //card04
                cardArray[1, 2, 6] = cardArray[0, 0, 0]; //card01

                DisplaySort1(ref cardArray);
            }
            #endregion

            #region Selection 2
            else if (clickCounter == 2 && selection2 == 'A')
            {
                // row A2
                cardArray[2, 0, 0] = cardArray[1, 2, 6];
                cardArray[2, 0, 1] = cardArray[1, 2, 3];
                cardArray[2, 0, 2] = cardArray[1, 2, 0];
                cardArray[2, 0, 3] = cardArray[1, 0, 4];
                cardArray[2, 0, 4] = cardArray[1, 0, 1];
                cardArray[2, 0, 5] = cardArray[1, 1, 5];
                cardArray[2, 0, 6] = cardArray[1, 1, 2];
                // row B2
                cardArray[2, 1, 0] = cardArray[1, 2, 5];
                cardArray[2, 1, 1] = cardArray[1, 2, 2];
                cardArray[2, 1, 2] = cardArray[1, 0, 6];
                cardArray[2, 1, 3] = cardArray[1, 0, 3];
                cardArray[2, 1, 4] = cardArray[1, 0, 0];
                cardArray[2, 1, 5] = cardArray[1, 1, 4];
                cardArray[2, 1, 6] = cardArray[1, 1, 1];
                // row C2
                cardArray[2, 2, 0] = cardArray[1, 2, 4];
                cardArray[2, 2, 1] = cardArray[1, 2, 1];
                cardArray[2, 2, 2] = cardArray[1, 0, 5];
                cardArray[2, 2, 3] = cardArray[1, 0, 2];
                cardArray[2, 2, 4] = cardArray[1, 1, 6];
                cardArray[2, 2, 5] = cardArray[1, 1, 3];
                cardArray[2, 2, 6] = cardArray[1, 1, 0];

                DisplaySort2(ref cardArray);
            }
            else if (clickCounter == 2 && selection2 == 'B')
            {
                // row A2
                cardArray[2, 0, 0] = cardArray[1, 2, 6];
                cardArray[2, 0, 1] = cardArray[1, 2, 3];
                cardArray[2, 0, 2] = cardArray[1, 2, 0];
                cardArray[2, 0, 3] = cardArray[1, 1, 4];
                cardArray[2, 0, 4] = cardArray[1, 1, 1];
                cardArray[2, 0, 5] = cardArray[1, 0, 5];
                cardArray[2, 0, 6] = cardArray[1, 0, 2];
                // row B2
                cardArray[2, 1, 0] = cardArray[1, 2, 5];
                cardArray[2, 1, 1] = cardArray[1, 2, 2];
                cardArray[2, 1, 2] = cardArray[1, 1, 6];
                cardArray[2, 1, 3] = cardArray[1, 1, 3];
                cardArray[2, 1, 4] = cardArray[1, 1, 0];
                cardArray[2, 1, 5] = cardArray[1, 0, 4];
                cardArray[2, 1, 6] = cardArray[1, 0, 1];
                // row C2
                cardArray[2, 2, 0] = cardArray[1, 2, 4];
                cardArray[2, 2, 1] = cardArray[1, 2, 1];
                cardArray[2, 2, 2] = cardArray[1, 1, 5];
                cardArray[2, 2, 3] = cardArray[1, 1, 2];
                cardArray[2, 2, 4] = cardArray[1, 0, 6];
                cardArray[2, 2, 5] = cardArray[1, 0, 3];
                cardArray[2, 2, 6] = cardArray[1, 0, 0];

                DisplaySort2(ref cardArray);
            }
            else if (clickCounter == 2 && selection2 == 'C')
            {
                // row A2
                cardArray[2, 0, 0] = cardArray[1, 1, 6];
                cardArray[2, 0, 1] = cardArray[1, 1, 3];
                cardArray[2, 0, 2] = cardArray[1, 1, 0];
                cardArray[2, 0, 3] = cardArray[1, 2, 4];
                cardArray[2, 0, 4] = cardArray[1, 2, 1];
                cardArray[2, 0, 5] = cardArray[1, 0, 5];
                cardArray[2, 0, 6] = cardArray[1, 0, 2];
                // row B2
                cardArray[2, 1, 0] = cardArray[1, 1, 5];
                cardArray[2, 1, 1] = cardArray[1, 1, 2];
                cardArray[2, 1, 2] = cardArray[1, 2, 6];
                cardArray[2, 1, 3] = cardArray[1, 2, 3];
                cardArray[2, 1, 4] = cardArray[1, 2, 0];
                cardArray[2, 1, 5] = cardArray[1, 0, 4];
                cardArray[2, 1, 6] = cardArray[1, 0, 1];
                // row C2
                cardArray[2, 2, 0] = cardArray[1, 1, 4];
                cardArray[2, 2, 1] = cardArray[1, 1, 1];
                cardArray[2, 2, 2] = cardArray[1, 2, 5];
                cardArray[2, 2, 3] = cardArray[1, 2, 2];
                cardArray[2, 2, 4] = cardArray[1, 0, 6];
                cardArray[2, 2, 5] = cardArray[1, 0, 3];
                cardArray[2, 2, 6] = cardArray[1, 0, 0];

                DisplaySort2(ref cardArray);
            }
            #endregion

            #region Selection 3
            else if (clickCounter == 3 && selection3 == 'A')
            {
                // row A3
                cardArray[3, 0, 0] = cardArray[2, 2, 6];
                cardArray[3, 0, 1] = cardArray[2, 2, 3];
                cardArray[3, 0, 2] = cardArray[2, 2, 0];
                cardArray[3, 0, 3] = cardArray[2, 0, 4];
                cardArray[3, 0, 4] = cardArray[2, 0, 1];
                cardArray[3, 0, 5] = cardArray[2, 1, 5];
                cardArray[3, 0, 6] = cardArray[2, 1, 2];
                // row B3
                cardArray[3, 1, 0] = cardArray[2, 2, 5];
                cardArray[3, 1, 1] = cardArray[2, 2, 2];
                cardArray[3, 1, 2] = cardArray[2, 0, 6];
                cardArray[3, 1, 3] = cardArray[2, 0, 3];
                cardArray[3, 1, 4] = cardArray[2, 0, 0];
                cardArray[3, 1, 5] = cardArray[2, 1, 4];
                cardArray[3, 1, 6] = cardArray[2, 1, 1];
                // row C3
                cardArray[3, 2, 0] = cardArray[2, 2, 4];
                cardArray[3, 2, 1] = cardArray[2, 2, 1];
                cardArray[3, 2, 2] = cardArray[2, 0, 5];
                cardArray[3, 2, 3] = cardArray[2, 0, 2];
                cardArray[3, 2, 4] = cardArray[2, 1, 6];
                cardArray[3, 2, 5] = cardArray[2, 1, 3];
                cardArray[3, 2, 6] = cardArray[2, 1, 0];

                DisplaySort3(ref cardArray);
            }
            else if (clickCounter == 3 && selection3 == 'B')
            {
                // row A3
                cardArray[3, 0, 0] = cardArray[2, 2, 6];
                cardArray[3, 0, 1] = cardArray[2, 2, 3];
                cardArray[3, 0, 2] = cardArray[2, 2, 0];
                cardArray[3, 0, 3] = cardArray[2, 1, 4];
                cardArray[3, 0, 4] = cardArray[2, 1, 1];
                cardArray[3, 0, 5] = cardArray[2, 0, 5];
                cardArray[3, 0, 6] = cardArray[2, 0, 2];
                // row B3
                cardArray[3, 1, 0] = cardArray[2, 2, 5];
                cardArray[3, 1, 1] = cardArray[2, 2, 2];
                cardArray[3, 1, 2] = cardArray[2, 1, 6];
                cardArray[3, 1, 3] = cardArray[2, 1, 3];
                cardArray[3, 1, 4] = cardArray[2, 1, 0];
                cardArray[3, 1, 5] = cardArray[2, 0, 4];
                cardArray[3, 1, 6] = cardArray[2, 0, 1];
                // row C3
                cardArray[3, 2, 0] = cardArray[2, 2, 4];
                cardArray[3, 2, 1] = cardArray[2, 2, 1];
                cardArray[3, 2, 2] = cardArray[2, 1, 5];
                cardArray[3, 2, 3] = cardArray[2, 1, 2];
                cardArray[3, 2, 4] = cardArray[2, 0, 6];
                cardArray[3, 2, 5] = cardArray[2, 0, 3];
                cardArray[3, 2, 6] = cardArray[2, 0, 0];

                DisplaySort3(ref cardArray);
            }
            else if (clickCounter == 3 && selection3 == 'C')
            {
                // row A3
                cardArray[3, 0, 0] = cardArray[2, 1, 6];
                cardArray[3, 0, 1] = cardArray[2, 1, 3];
                cardArray[3, 0, 2] = cardArray[2, 1, 0];
                cardArray[3, 0, 3] = cardArray[2, 2, 4];
                cardArray[3, 0, 4] = cardArray[2, 2, 1];
                cardArray[3, 0, 5] = cardArray[2, 0, 5];
                cardArray[3, 0, 6] = cardArray[2, 0, 2];
                // row B3
                cardArray[3, 1, 0] = cardArray[2, 1, 5];
                cardArray[3, 1, 1] = cardArray[2, 1, 2];
                cardArray[3, 1, 2] = cardArray[2, 2, 6];
                cardArray[3, 1, 3] = cardArray[2, 2, 3];
                cardArray[3, 1, 4] = cardArray[2, 2, 0];
                cardArray[3, 1, 5] = cardArray[2, 0, 4];
                cardArray[3, 1, 6] = cardArray[2, 0, 1];
                // row C3
                cardArray[3, 2, 0] = cardArray[2, 1, 4];
                cardArray[3, 2, 1] = cardArray[2, 1, 1];
                cardArray[3, 2, 2] = cardArray[2, 2, 5];
                cardArray[3, 2, 3] = cardArray[2, 2, 2];
                cardArray[3, 2, 4] = cardArray[2, 0, 6];
                cardArray[3, 2, 5] = cardArray[2, 0, 3];
                cardArray[3, 2, 6] = cardArray[2, 0, 0];

                DisplaySort3(ref cardArray);
            }
            #endregion
        }
        #endregion

        #region Deal Cards (display)
        public void DealCards(ref string[,,] arrayName)
        {
            //Row A
            Bitmap posA0_0 = new Bitmap(imagePath + arrayName[0, 0, 0] + ".png");
            pbxRowA0_0.Image = posA0_0;
            Bitmap posA0_1 = new Bitmap(imagePath + arrayName[0, 0, 1] + ".png");
            pbxRowA0_1.Image = posA0_1;
            Bitmap posA0_2 = new Bitmap(imagePath + arrayName[0, 0, 2] + ".png");
            pbxRowA0_2.Image = posA0_2;
            Bitmap posA0_3 = new Bitmap(imagePath + arrayName[0, 0, 3] + ".png");
            pbxRowA0_3.Image = posA0_3;
            Bitmap posA0_4 = new Bitmap(imagePath + arrayName[0, 0, 4] + ".png");
            pbxRowA0_4.Image = posA0_4;
            Bitmap posA0_5 = new Bitmap(imagePath + arrayName[0, 0, 5] + ".png");
            pbxRowA0_5.Image = posA0_5;
            Bitmap posA0_6 = new Bitmap(imagePath + arrayName[0, 0, 6] + ".png");
            pbxRowA0_6.Image = posA0_6;

            //Row B
            Bitmap posB0_0 = new Bitmap(imagePath + arrayName[0, 1, 0] + ".png");
            pbxRowB0_0.Image = posB0_0;
            Bitmap posB0_1 = new Bitmap(imagePath + arrayName[0, 1, 1] + ".png");
            pbxRowB0_1.Image = posB0_1;
            Bitmap posB0_2 = new Bitmap(imagePath + arrayName[0, 1, 2] + ".png");
            pbxRowB0_2.Image = posB0_2;
            Bitmap posB0_3 = new Bitmap(imagePath + arrayName[0, 1, 3] + ".png");
            pbxRowB0_3.Image = posB0_3;
            Bitmap posB0_4 = new Bitmap(imagePath + arrayName[0, 1, 4] + ".png");
            pbxRowB0_4.Image = posB0_4;
            Bitmap posB0_5 = new Bitmap(imagePath + arrayName[0, 1, 5] + ".png");
            pbxRowB0_5.Image = posB0_5;
            Bitmap posB0_6 = new Bitmap(imagePath + arrayName[0, 1, 6] + ".png");
            pbxRowB0_6.Image = posB0_6;

            //Row C
            Bitmap posC0_0 = new Bitmap(imagePath + arrayName[0, 2, 0] + ".png");
            pbxRowC0_0.Image = posC0_0;
            Bitmap posC0_1 = new Bitmap(imagePath + arrayName[0, 2, 1] + ".png");
            pbxRowC0_1.Image = posC0_1;
            Bitmap posC0_2 = new Bitmap(imagePath + arrayName[0, 2, 2] + ".png");
            pbxRowC0_2.Image = posC0_2;
            Bitmap posC0_3 = new Bitmap(imagePath + arrayName[0, 2, 3] + ".png");
            pbxRowC0_3.Image = posC0_3;
            Bitmap posC0_4 = new Bitmap(imagePath + arrayName[0, 2, 4] + ".png");
            pbxRowC0_4.Image = posC0_4;
            Bitmap posC0_5 = new Bitmap(imagePath + arrayName[0, 2, 5] + ".png");
            pbxRowC0_5.Image = posC0_5;
            Bitmap posC0_6 = new Bitmap(imagePath + arrayName[0, 2, 6] + ".png");
            pbxRowC0_6.Image = posC0_6;
        }
        #endregion

        #region Sort 1
        //public void Sort1(string[,,] arrayName)
        //{
        //    if (clickCounter == 1 && selection1 == 'A')
        //    {
        //        // row A1
        //        arrayName[1, 0, 0] = arrayName[0, 2, 6]; //card21
        //        arrayName[1, 0, 1] = arrayName[0, 2, 3]; //card18
        //        arrayName[1, 0, 2] = arrayName[0, 2, 0]; //card15
        //        arrayName[1, 0, 3] = arrayName[0, 0, 4]; //card05
        //        arrayName[1, 0, 4] = arrayName[0, 0, 1]; //card02
        //        arrayName[1, 0, 5] = arrayName[0, 1, 5]; //card13
        //        arrayName[1, 0, 6] = arrayName[0, 1, 2]; //card10
        //        // row B1
        //        arrayName[1, 1, 0] = arrayName[0, 2, 5]; //card20
        //        arrayName[1, 1, 1] = arrayName[0, 2, 2]; //card17
        //        arrayName[1, 1, 2] = arrayName[0, 0, 6]; //card07
        //        arrayName[1, 1, 3] = arrayName[0, 0, 3]; //card04
        //        arrayName[1, 1, 4] = arrayName[0, 0, 0]; //card01
        //        arrayName[1, 1, 5] = arrayName[0, 1, 4]; //card12
        //        arrayName[1, 1, 6] = arrayName[0, 1, 1]; //card09
        //        // row C1
        //        arrayName[1, 2, 0] = arrayName[0, 2, 4]; //card19
        //        arrayName[1, 2, 1] = arrayName[0, 2, 1]; //card16
        //        arrayName[1, 2, 2] = arrayName[0, 0, 5]; //card06
        //        arrayName[1, 2, 3] = arrayName[0, 0, 2]; //card03
        //        arrayName[1, 2, 4] = arrayName[0, 1, 6]; //card14
        //        arrayName[1, 2, 5] = arrayName[0, 1, 3]; //card11
        //        arrayName[1, 2, 6] = arrayName[0, 1, 0]; //card08
        //    }
        //    else if (clickCounter == 1 && selection1 == 'B')
        //    {
        //        // row A1
        //        arrayName[1, 0, 0] = arrayName[0, 2, 6]; //card21
        //        arrayName[1, 0, 1] = arrayName[0, 2, 3]; //card18
        //        arrayName[1, 0, 2] = arrayName[0, 2, 0]; //card15
        //        arrayName[1, 0, 3] = arrayName[0, 1, 4]; //card12
        //        arrayName[1, 0, 4] = arrayName[0, 1, 1]; //card09
        //        arrayName[1, 0, 5] = arrayName[0, 0, 5]; //card06
        //        arrayName[1, 0, 6] = arrayName[0, 0, 2]; //card03
        //        // row B1
        //        arrayName[1, 1, 0] = arrayName[0, 2, 5]; //card20
        //        arrayName[1, 1, 1] = arrayName[0, 2, 2]; //card17
        //        arrayName[1, 1, 2] = arrayName[0, 1, 6]; //card14
        //        arrayName[1, 1, 3] = arrayName[0, 1, 3]; //card11
        //        arrayName[1, 1, 4] = arrayName[0, 1, 0]; //card08
        //        arrayName[1, 1, 5] = arrayName[0, 0, 4]; //card05
        //        arrayName[1, 1, 6] = arrayName[0, 0, 1]; //card02
        //        // row C1
        //        arrayName[1, 2, 0] = arrayName[0, 2, 4]; //card19
        //        arrayName[1, 2, 1] = arrayName[0, 2, 1]; //card16
        //        arrayName[1, 2, 2] = arrayName[0, 1, 5]; //card13
        //        arrayName[1, 2, 3] = arrayName[0, 1, 2]; //card10
        //        arrayName[1, 2, 4] = arrayName[0, 0, 6]; //card07
        //        arrayName[1, 2, 5] = arrayName[0, 0, 3]; //card04
        //        arrayName[1, 2, 6] = arrayName[0, 0, 0]; //card01
        //    }
        //    else if (clickCounter == 1 && selection1 == 'C')
        //    {
        //        // row A1
        //        arrayName[1, 0, 0] = arrayName[0, 1, 6]; //card14
        //        arrayName[1, 0, 1] = arrayName[0, 1, 3]; //card11
        //        arrayName[1, 0, 2] = arrayName[0, 1, 0]; //card08
        //        arrayName[1, 0, 3] = arrayName[0, 2, 4]; //card19
        //        arrayName[1, 0, 4] = arrayName[0, 2, 1]; //card16
        //        arrayName[1, 0, 5] = arrayName[0, 0, 5]; //card06
        //        arrayName[1, 0, 6] = arrayName[0, 0, 2]; //card03
        //        // row B1
        //        arrayName[1, 1, 0] = arrayName[0, 1, 5]; //card13
        //        arrayName[1, 1, 1] = arrayName[0, 1, 2]; //card10
        //        arrayName[1, 1, 2] = arrayName[0, 2, 6]; //card21
        //        arrayName[1, 1, 3] = arrayName[0, 2, 3]; //card18
        //        arrayName[1, 1, 4] = arrayName[0, 2, 0]; //card15
        //        arrayName[1, 1, 5] = arrayName[0, 0, 4]; //card05
        //        arrayName[1, 1, 6] = arrayName[0, 0, 1]; //card02
        //        // row C1
        //        arrayName[1, 2, 0] = arrayName[0, 1, 4]; //card12
        //        arrayName[1, 2, 1] = arrayName[0, 1, 1]; //card09
        //        arrayName[1, 2, 2] = arrayName[0, 2, 5]; //card20
        //        arrayName[1, 2, 3] = arrayName[0, 2, 2]; //card17
        //        arrayName[1, 2, 4] = arrayName[0, 0, 6]; //card07
        //        arrayName[1, 2, 5] = arrayName[0, 0, 3]; //card04
        //        arrayName[1, 2, 6] = arrayName[0, 0, 0]; //card01
        //    }
        //}
        #endregion

        #region Sort 2
        //public void Sort2(ref string[,,] arrayName)
        //{
        //    if (clickCounter == 2 && selection2 == 'A')
        //    {
        //        // row A2
        //        arrayName[2, 0, 0] = arrayName[1, 2, 6];
        //        arrayName[2, 0, 1] = arrayName[1, 2, 3];
        //        arrayName[2, 0, 2] = arrayName[1, 2, 0];
        //        arrayName[2, 0, 3] = arrayName[1, 0, 4];
        //        arrayName[2, 0, 4] = arrayName[1, 0, 1];
        //        arrayName[2, 0, 5] = arrayName[1, 1, 5];
        //        arrayName[2, 0, 6] = arrayName[1, 1, 2];
        //        // row B2
        //        arrayName[2, 1, 0] = arrayName[1, 2, 5];
        //        arrayName[2, 1, 1] = arrayName[1, 2, 2];
        //        arrayName[2, 1, 2] = arrayName[1, 0, 6];
        //        arrayName[2, 1, 3] = arrayName[1, 0, 3];
        //        arrayName[2, 1, 4] = arrayName[1, 0, 0];
        //        arrayName[2, 1, 5] = arrayName[1, 1, 4];
        //        arrayName[2, 1, 6] = arrayName[1, 1, 1];
        //        // row C2
        //        arrayName[2, 2, 0] = arrayName[1, 2, 4];
        //        arrayName[2, 2, 1] = arrayName[1, 2, 1];
        //        arrayName[2, 2, 2] = arrayName[1, 0, 5];
        //        arrayName[2, 2, 3] = arrayName[1, 0, 2];
        //        arrayName[2, 2, 4] = arrayName[1, 1, 6];
        //        arrayName[2, 2, 5] = arrayName[1, 1, 3];
        //        arrayName[2, 2, 6] = arrayName[1, 1, 0];
        //    }
        //    else if (clickCounter == 2 && selection2 == 'B')
        //    {
        //        // row A2
        //        arrayName[2, 0, 0] = arrayName[1, 2, 6];
        //        arrayName[2, 0, 1] = arrayName[1, 2, 3];
        //        arrayName[2, 0, 2] = arrayName[1, 2, 0];
        //        arrayName[2, 0, 3] = arrayName[1, 1, 4];
        //        arrayName[2, 0, 4] = arrayName[1, 1, 1];
        //        arrayName[2, 0, 5] = arrayName[1, 0, 5];
        //        arrayName[2, 0, 6] = arrayName[1, 0, 2];
        //        // row B2
        //        arrayName[2, 1, 0] = arrayName[1, 2, 5];
        //        arrayName[2, 1, 1] = arrayName[1, 2, 2];
        //        arrayName[2, 1, 2] = arrayName[1, 1, 6];
        //        arrayName[2, 1, 3] = arrayName[1, 1, 3];
        //        arrayName[2, 1, 4] = arrayName[1, 1, 0];
        //        arrayName[2, 1, 5] = arrayName[1, 0, 4];
        //        arrayName[2, 1, 6] = arrayName[1, 0, 1];
        //        // row C2
        //        arrayName[2, 2, 0] = arrayName[1, 2, 4];
        //        arrayName[2, 2, 1] = arrayName[1, 2, 1];
        //        arrayName[2, 2, 2] = arrayName[1, 1, 5];
        //        arrayName[2, 2, 3] = arrayName[1, 1, 2];
        //        arrayName[2, 2, 4] = arrayName[1, 0, 6];
        //        arrayName[2, 2, 5] = arrayName[1, 0, 3];
        //        arrayName[2, 2, 6] = arrayName[1, 0, 0];
        //    }
        //    else if (clickCounter == 2 && selection2 == 'C')
        //    {
        //        // row A2
        //        arrayName[2, 0, 0] = arrayName[1, 1, 6];
        //        arrayName[2, 0, 1] = arrayName[1, 1, 3];
        //        arrayName[2, 0, 2] = arrayName[1, 1, 0];
        //        arrayName[2, 0, 3] = arrayName[1, 2, 4];
        //        arrayName[2, 0, 4] = arrayName[1, 2, 1];
        //        arrayName[2, 0, 5] = arrayName[1, 0, 5];
        //        arrayName[2, 0, 6] = arrayName[1, 0, 2];
        //        // row B2
        //        arrayName[2, 1, 0] = arrayName[1, 1, 5];
        //        arrayName[2, 1, 1] = arrayName[1, 1, 2];
        //        arrayName[2, 1, 2] = arrayName[1, 2, 6];
        //        arrayName[2, 1, 3] = arrayName[1, 2, 3];
        //        arrayName[2, 1, 4] = arrayName[1, 2, 0];
        //        arrayName[2, 1, 5] = arrayName[1, 0, 4];
        //        arrayName[2, 1, 6] = arrayName[1, 0, 1];
        //        // row C2
        //        arrayName[2, 2, 0] = arrayName[1, 1, 4];
        //        arrayName[2, 2, 1] = arrayName[1, 1, 1];
        //        arrayName[2, 2, 2] = arrayName[1, 2, 5];
        //        arrayName[2, 2, 3] = arrayName[1, 2, 2];
        //        arrayName[2, 2, 4] = arrayName[1, 0, 6];
        //        arrayName[2, 2, 5] = arrayName[1, 0, 3];
        //        arrayName[2, 2, 6] = arrayName[1, 0, 0];
        //    }
        //}
        #endregion

        #region Sort 3
        //public void Sort3(ref string[,,] arrayName)
        //{
        //    if (clickCounter == 3 && selection3 == 'A')
        //    {
        //        // row A3
        //        arrayName[3, 0, 0] = arrayName[2, 2, 6];
        //        arrayName[3, 0, 1] = arrayName[2, 2, 3];
        //        arrayName[3, 0, 2] = arrayName[2, 2, 0];
        //        arrayName[3, 0, 3] = arrayName[2, 0, 4];
        //        arrayName[3, 0, 4] = arrayName[2, 0, 1];
        //        arrayName[3, 0, 5] = arrayName[2, 1, 5];
        //        arrayName[3, 0, 6] = arrayName[2, 1, 2];
        //        // row B3
        //        arrayName[3, 1, 0] = arrayName[2, 2, 5];
        //        arrayName[3, 1, 1] = arrayName[2, 2, 2];
        //        arrayName[3, 1, 2] = arrayName[2, 0, 6];
        //        arrayName[3, 1, 3] = arrayName[2, 0, 3];
        //        arrayName[3, 1, 4] = arrayName[2, 0, 0];
        //        arrayName[3, 1, 5] = arrayName[2, 1, 4];
        //        arrayName[3, 1, 6] = arrayName[2, 1, 1];
        //        // row C3
        //        arrayName[3, 2, 0] = arrayName[2, 2, 4];
        //        arrayName[3, 2, 1] = arrayName[2, 2, 1];
        //        arrayName[3, 2, 2] = arrayName[2, 0, 5];
        //        arrayName[3, 2, 3] = arrayName[2, 0, 2];
        //        arrayName[3, 2, 4] = arrayName[2, 1, 6];
        //        arrayName[3, 2, 5] = arrayName[2, 1, 3];
        //        arrayName[3, 2, 6] = arrayName[2, 1, 0];
        //    }
        //    else if (clickCounter == 3 && selection3 == 'B')
        //    {
        //        // row A3
        //        arrayName[3, 0, 0] = arrayName[2, 2, 6];
        //        arrayName[3, 0, 1] = arrayName[2, 2, 3];
        //        arrayName[3, 0, 2] = arrayName[2, 2, 0];
        //        arrayName[3, 0, 3] = arrayName[2, 1, 4];
        //        arrayName[3, 0, 4] = arrayName[2, 1, 1];
        //        arrayName[3, 0, 5] = arrayName[2, 0, 5];
        //        arrayName[3, 0, 6] = arrayName[2, 0, 2];
        //        // row B3
        //        arrayName[3, 1, 0] = arrayName[2, 2, 5];
        //        arrayName[3, 1, 1] = arrayName[2, 2, 2];
        //        arrayName[3, 1, 2] = arrayName[2, 1, 6];
        //        arrayName[3, 1, 3] = arrayName[2, 1, 3];
        //        arrayName[3, 1, 4] = arrayName[2, 1, 0];
        //        arrayName[3, 1, 5] = arrayName[2, 0, 4];
        //        arrayName[3, 1, 6] = arrayName[2, 0, 1];
        //        // row C3
        //        arrayName[3, 2, 0] = arrayName[2, 2, 4];
        //        arrayName[3, 2, 1] = arrayName[2, 2, 1];
        //        arrayName[3, 2, 2] = arrayName[2, 1, 5];
        //        arrayName[3, 2, 3] = arrayName[2, 1, 2];
        //        arrayName[3, 2, 4] = arrayName[2, 0, 6];
        //        arrayName[3, 2, 5] = arrayName[2, 0, 3];
        //        arrayName[3, 2, 6] = arrayName[2, 0, 0];
        //    }
        //    else if (clickCounter == 3 && selection3 == 'C')
        //    {
        //        // row A3
        //        arrayName[3, 0, 0] = arrayName[2, 1, 6];
        //        arrayName[3, 0, 1] = arrayName[2, 1, 3];
        //        arrayName[3, 0, 2] = arrayName[2, 1, 0];
        //        arrayName[3, 0, 3] = arrayName[2, 2, 4];
        //        arrayName[3, 0, 4] = arrayName[2, 2, 1];
        //        arrayName[3, 0, 5] = arrayName[2, 0, 5];
        //        arrayName[3, 0, 6] = arrayName[2, 0, 2];
        //        // row B3
        //        arrayName[3, 1, 0] = arrayName[2, 1, 5];
        //        arrayName[3, 1, 1] = arrayName[2, 1, 2];
        //        arrayName[3, 1, 2] = arrayName[2, 2, 6];
        //        arrayName[3, 1, 3] = arrayName[2, 2, 3];
        //        arrayName[3, 1, 4] = arrayName[2, 2, 0];
        //        arrayName[3, 1, 5] = arrayName[2, 0, 4];
        //        arrayName[3, 1, 6] = arrayName[2, 0, 1];
        //        // row C3
        //        arrayName[3, 2, 0] = arrayName[2, 1, 4];
        //        arrayName[3, 2, 1] = arrayName[2, 1, 1];
        //        arrayName[3, 2, 2] = arrayName[2, 2, 5];
        //        arrayName[3, 2, 3] = arrayName[2, 2, 2];
        //        arrayName[3, 2, 4] = arrayName[2, 0, 6];
        //        arrayName[3, 2, 5] = arrayName[2, 0, 3];
        //        arrayName[3, 2, 6] = arrayName[2, 0, 0];
        //    }
        //}
        #endregion

        #region Display Sort 1
        public void DisplaySort1(ref string[,,] arrayName)
        {
            //Row A
            Bitmap posA0_0 = new Bitmap(imagePath + arrayName[1, 0, 0] + ".png");
            pbxRowA0_0.Image = posA0_0;
            Bitmap posA0_1 = new Bitmap(imagePath + arrayName[1, 0, 1] + ".png");
            pbxRowA0_1.Image = posA0_1;
            Bitmap posA0_2 = new Bitmap(imagePath + arrayName[1, 0, 2] + ".png");
            pbxRowA0_2.Image = posA0_2;
            Bitmap posA0_3 = new Bitmap(imagePath + arrayName[1, 0, 3] + ".png");
            pbxRowA0_3.Image = posA0_3;
            Bitmap posA0_4 = new Bitmap(imagePath + arrayName[1, 0, 4] + ".png");
            pbxRowA0_4.Image = posA0_4;
            Bitmap posA0_5 = new Bitmap(imagePath + arrayName[1, 0, 5] + ".png");
            pbxRowA0_5.Image = posA0_5;
            Bitmap posA0_6 = new Bitmap(imagePath + arrayName[1, 0, 6] + ".png");
            pbxRowA0_6.Image = posA0_6;

            //Row B
            Bitmap posB0_0 = new Bitmap(imagePath + arrayName[1, 1, 0] + ".png");
            pbxRowB0_0.Image = posB0_0;
            Bitmap posB0_1 = new Bitmap(imagePath + arrayName[1, 1, 1] + ".png");
            pbxRowB0_1.Image = posB0_1;
            Bitmap posB0_2 = new Bitmap(imagePath + arrayName[1, 1, 2] + ".png");
            pbxRowB0_2.Image = posB0_2;
            Bitmap posB0_3 = new Bitmap(imagePath + arrayName[1, 1, 3] + ".png");
            pbxRowB0_3.Image = posB0_3;
            Bitmap posB0_4 = new Bitmap(imagePath + arrayName[1, 1, 4] + ".png");
            pbxRowB0_4.Image = posB0_4;
            Bitmap posB0_5 = new Bitmap(imagePath + arrayName[1, 1, 5] + ".png");
            pbxRowB0_5.Image = posB0_5;
            Bitmap posB0_6 = new Bitmap(imagePath + arrayName[1, 1, 6] + ".png");
            pbxRowB0_6.Image = posB0_6;

            //Row C
            Bitmap posC0_0 = new Bitmap(imagePath + arrayName[1, 2, 0] + ".png");
            pbxRowC0_0.Image = posC0_0;
            Bitmap posC0_1 = new Bitmap(imagePath + arrayName[1, 2, 1] + ".png");
            pbxRowC0_1.Image = posC0_1;
            Bitmap posC0_2 = new Bitmap(imagePath + arrayName[1, 2, 2] + ".png");
            pbxRowC0_2.Image = posC0_2;
            Bitmap posC0_3 = new Bitmap(imagePath + arrayName[1, 2, 3] + ".png");
            pbxRowC0_3.Image = posC0_3;
            Bitmap posC0_4 = new Bitmap(imagePath + arrayName[1, 2, 4] + ".png");
            pbxRowC0_4.Image = posC0_4;
            Bitmap posC0_5 = new Bitmap(imagePath + arrayName[1, 2, 5] + ".png");
            pbxRowC0_5.Image = posC0_5;
            Bitmap posC0_6 = new Bitmap(imagePath + arrayName[1, 2, 6] + ".png");
            pbxRowC0_6.Image = posC0_6;
        }
        #endregion

        #region Display Sort 2
        public void DisplaySort2(ref string[,,] arrayName)
        {
            //Row A
            Bitmap posA0_0 = new Bitmap(imagePath + arrayName[2, 0, 0] + ".png");
            pbxRowA0_0.Image = posA0_0;
            Bitmap posA0_1 = new Bitmap(imagePath + arrayName[2, 0, 1] + ".png");
            pbxRowA0_1.Image = posA0_1;
            Bitmap posA0_2 = new Bitmap(imagePath + arrayName[2, 0, 2] + ".png");
            pbxRowA0_2.Image = posA0_2;
            Bitmap posA0_3 = new Bitmap(imagePath + arrayName[2, 0, 3] + ".png");
            pbxRowA0_3.Image = posA0_3;
            Bitmap posA0_4 = new Bitmap(imagePath + arrayName[2, 0, 4] + ".png");
            pbxRowA0_4.Image = posA0_4;
            Bitmap posA0_5 = new Bitmap(imagePath + arrayName[2, 0, 5] + ".png");
            pbxRowA0_5.Image = posA0_5;
            Bitmap posA0_6 = new Bitmap(imagePath + arrayName[2, 0, 6] + ".png");
            pbxRowA0_6.Image = posA0_6;

            //Row B
            Bitmap posB0_0 = new Bitmap(imagePath + arrayName[2, 1, 0] + ".png");
            pbxRowB0_0.Image = posB0_0;
            Bitmap posB0_1 = new Bitmap(imagePath + arrayName[2, 1, 1] + ".png");
            pbxRowB0_1.Image = posB0_1;
            Bitmap posB0_2 = new Bitmap(imagePath + arrayName[2, 1, 2] + ".png");
            pbxRowB0_2.Image = posB0_2;
            Bitmap posB0_3 = new Bitmap(imagePath + arrayName[2, 1, 3] + ".png");
            pbxRowB0_3.Image = posB0_3;
            Bitmap posB0_4 = new Bitmap(imagePath + arrayName[2, 1, 4] + ".png");
            pbxRowB0_4.Image = posB0_4;
            Bitmap posB0_5 = new Bitmap(imagePath + arrayName[2, 1, 5] + ".png");
            pbxRowB0_5.Image = posB0_5;
            Bitmap posB0_6 = new Bitmap(imagePath + arrayName[2, 1, 6] + ".png");
            pbxRowB0_6.Image = posB0_6;

            //Row C
            Bitmap posC0_0 = new Bitmap(imagePath + arrayName[2, 2, 0] + ".png");
            pbxRowC0_0.Image = posC0_0;
            Bitmap posC0_1 = new Bitmap(imagePath + arrayName[2, 2, 1] + ".png");
            pbxRowC0_1.Image = posC0_1;
            Bitmap posC0_2 = new Bitmap(imagePath + arrayName[2, 2, 2] + ".png");
            pbxRowC0_2.Image = posC0_2;
            Bitmap posC0_3 = new Bitmap(imagePath + arrayName[2, 2, 3] + ".png");
            pbxRowC0_3.Image = posC0_3;
            Bitmap posC0_4 = new Bitmap(imagePath + arrayName[2, 2, 4] + ".png");
            pbxRowC0_4.Image = posC0_4;
            Bitmap posC0_5 = new Bitmap(imagePath + arrayName[2, 2, 5] + ".png");
            pbxRowC0_5.Image = posC0_5;
            Bitmap posC0_6 = new Bitmap(imagePath + arrayName[2, 2, 6] + ".png");
            pbxRowC0_6.Image = posC0_6;
        }
        #endregion

        #region Display Sort 3
        public void DisplaySort3(ref string[,,] arrayName)
        {
            //Row A
            Bitmap posA0_0 = new Bitmap(imagePath + "Backing.png");
            pbxRowA0_0.Image = posA0_0;
            Bitmap posA0_1 = new Bitmap(imagePath + "Backing.png");
            pbxRowA0_1.Image = posA0_1;
            Bitmap posA0_2 = new Bitmap(imagePath + "Backing.png");
            pbxRowA0_2.Image = posA0_2;
            Bitmap posA0_3 = new Bitmap(imagePath + "Backing.png");
            pbxRowA0_3.Image = posA0_3;
            Bitmap posA0_4 = new Bitmap(imagePath + "Backing.png");
            pbxRowA0_4.Image = posA0_4;
            Bitmap posA0_5 = new Bitmap(imagePath + "Backing.png");
            pbxRowA0_5.Image = posA0_5;
            Bitmap posA0_6 = new Bitmap(imagePath + "Backing.png");
            pbxRowA0_6.Image = posA0_6;

            //Row B
            Bitmap posB0_0 = new Bitmap(imagePath + "Backing.png");
            pbxRowB0_0.Image = posB0_0;
            Bitmap posB0_1 = new Bitmap(imagePath + "Backing.png");
            pbxRowB0_1.Image = posB0_1;
            Bitmap posB0_2 = new Bitmap(imagePath + "Backing.png");
            pbxRowB0_2.Image = posB0_2;
            Bitmap posB0_3 = new Bitmap(imagePath + arrayName[3, 1, 3] + ".png");
            pbxRowB0_3.Image = posB0_3;
            Bitmap posB0_4 = new Bitmap(imagePath + "Backing.png");
            pbxRowB0_4.Image = posB0_4;
            Bitmap posB0_5 = new Bitmap(imagePath + "Backing.png");
            pbxRowB0_5.Image = posB0_5;
            Bitmap posB0_6 = new Bitmap(imagePath + "Backing.png");
            pbxRowB0_6.Image = posB0_6;

            //Row C
            Bitmap posC0_0 = new Bitmap(imagePath + "Backing.png");
            pbxRowC0_0.Image = posC0_0;
            Bitmap posC0_1 = new Bitmap(imagePath + "Backing.png");
            pbxRowC0_1.Image = posC0_1;
            Bitmap posC0_2 = new Bitmap(imagePath + "Backing.png");
            pbxRowC0_2.Image = posC0_2;
            Bitmap posC0_3 = new Bitmap(imagePath + "Backing.png");
            pbxRowC0_3.Image = posC0_3;
            Bitmap posC0_4 = new Bitmap(imagePath + "Backing.png");
            pbxRowC0_4.Image = posC0_4;
            Bitmap posC0_5 = new Bitmap(imagePath + "Backing.png");
            pbxRowC0_5.Image = posC0_5;
            Bitmap posC0_6 = new Bitmap(imagePath + "Backing.png");
            pbxRowC0_6.Image = posC0_6;
        }
        #endregion

        #region Selection (A)
        public void BtnRowA_Click(object sender, EventArgs e)
        {
            if (cardArray[0, 0, 0] != null)
            {
                clickCounter += 1;

                if (clickCounter == 1)
                {
                    selection1 = 'A';
                }
                else if (clickCounter == 2)
                {
                    selection2 = 'A';
                }
                else if (clickCounter == 3)
                {
                    selection3 = 'A';
                }
                Start();
            }
            else
            {
                MessageBox.Show("You must click the 'Deal Cards' button to begin");
            }
        }
        #endregion

        #region Selection (B)
        public void BtnRowB_Click(object sender, EventArgs e)
        {
            if (cardArray[0, 0, 0] != null)
            {
                clickCounter += 1;

                if (clickCounter == 1)
                {
                    selection1 = 'B';
                }
                else if (clickCounter == 2)
                {
                    selection2 = 'B';
                }
                else if (clickCounter == 3)
                {
                    selection3 = 'B';
                }
                Start();
            }
            else
            {
                MessageBox.Show("You must click the 'Deal Cards' button to begin");
            }
        }
        #endregion

        #region Selection (C)
        public void BtnRowC_Click(object sender, EventArgs e)
        {
            if (cardArray[0, 0, 0] != null)
            {
                clickCounter += 1;

                if (clickCounter == 1)
                {
                    selection1 = 'C';
                }
                else if (clickCounter == 2)
                {
                    selection2 = 'C';
                }
                else if (clickCounter == 3)
                {
                    selection3 = 'C';
                }
                Start();
            }
            else
            {
                MessageBox.Show("You must click the 'Deal Cards' button to begin");
            }
        }
        #endregion

        public void PassResult(string cardName)
        {
            cardArray[3, 1, 3] = cardName;
        }

        private void Main_Trick_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
