# 21-Card-Trick
This project is a virtual replication of a classic card trick using a 3-D array in C# and WinForms with image files to represent all playing cards in a deck.

In the real-world version of this card trick, a dealer would randomly select 21 cards from a deck and place them face up into three vertical columns, 
with seven cards in each. A particpant would be asked to mentally select one of the cards.  The dealer whould then ask the participant to indicate which 
of the three columns the card was in.  Then, the dealer would collect the cards into a stack while keeping cards of the named column between the cards of 
the other two columns. Next, the dealer would distribute the cards a second time into three columns once again. The top card in the stack is placed face up 
in column one, the second card in column two, the third in column three, the fourth back in column one . . . and so on.  In this sequence, the cards are 
redistributed in a specific order into different columns than their original configuration based on the column named by the participant.  After the cards 
are dealt a second time, the participant is asked again to indicate which row their card is in. Again, the dealer collects all of the cards into a stack 
while keeping all of the cards of the named column in the middle. The cards are redistrubuted into three columns for the third and final iteration. The 
participant indicates the column containing their card one last time. The dealer collects the cards and finishes the trick by revealing the card in the 
eleventh position. The card that was originally selected by the participant gravitated to the center position due to mathmatical permutation of the cards 
during each of the three iterations.

The first planning task for this project was to deciper the patterns of card sorting in all possible variations for each of the three iterations. To accomplish 
this, the trick was performed with real cards while recording all 21 permutations and each card’s change in position through each iteration. This anaylsis 
revealed the sorting algorithm for the trick. WinForms was selected as the medium for building this project as an appropriate platform to allow for manipulation 
and display of graphics with the card images.  A significant change in presentation was made to display the cards in rows instead of columns in order to 
accommodate the landscape orientation of computer screens that the application would be viewed. This change also required transposing the position of array 
elements compared to the original column configuration, but it also made it easier to think in terms of array positions where each of the cards would be sorted.

The heart of the code in this project lies with the three-dimentional array.  First, the cards are randomly selected as string names for the image files. A player 
can click the “Deal” button as many times as they wish in order to start with a different set.  Each time the cards are dealt, the randomly selected card names are 
then placed in the base array (subset 0). The other subsets of the array start out with “VOID” values that serve as placeholders. When the player clicks a button 
for one of the rows, the card names are sorted in a specific order into one of the other subsets of the array based on the player’s row selection (A, B, or C). 
The player’s first selection sorts the cards into subset 1, the second selection into subset 2, and the third into subset 3. A counter is used to keep track of how
many times the player has made a selection.  The cards are sorted differently based on how many selections have already been made and the actual value of the 
selection (A, B, or C). Finally, the virtual version of this trick ends by revealing the card in the [3, 1, 3] element position, a.k.a. card #11.
