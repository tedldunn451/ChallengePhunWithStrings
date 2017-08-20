using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Ted Dunn";
            // In my case, the result would be:
            // robaT boB
            char[] letters = name.ToCharArray();
            string reversedName = "";

            for (int i = letters.Length - 1; i >= 0; i--)
            {
                reversedName += letters[i];
            }

            reverseNameLabel.Text = reversedName;

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            string[] nameArray = new string[names.Length];
            string reverseOrder = "";

            nameArray = names.Split(',');

            for (int i = nameArray.Length - 1; i >= 0; i--)
            {
                reverseOrder += nameArray[i] + ",";
            }

            reverseListLabel.Text = reverseOrder;

            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string[] nameList = { "luke", "leia", "han", "Chewbacca" };
            int totalChars = 14;
            int padsNeeded;
            int padLeft;
            //int padRight;
            char pad = '*';
            string result = "";

            for (int i = 0; i < nameList.Length; i++)
            {
                string character = nameList[i];
                padsNeeded = totalChars - character.Length;
                padLeft = padsNeeded / 2;
                //padRight = padsNeeded - padLeft;
                string leftPadded = character.PadLeft(padLeft + character.Length, pad);
                string allPadded = leftPadded.PadRight(totalChars, pad);
                result += allPadded + "<br />";
            }

            resultLabel.Text = result;

            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Replace("remove-me", "");
            puzzle = char.ToUpper(puzzle[0]) + puzzle.Substring(1);

            puzzleLabel.Text = puzzle;
        }
    }
}