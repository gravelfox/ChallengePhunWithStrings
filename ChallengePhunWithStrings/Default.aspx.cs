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
            string name = "Bob Tabor";
            // In my case, the result would be:
            // robaT boB
            string eman = "";
            for (int i = 0; i < name.Length; i++)
            {
                eman += name.Substring(name.Length - i - 1, 1);
            }
            resultLabel.Text = eman + "<br /><br />";

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            string[] namesArray = names.Split(',');
            for (int i = namesArray.Length - 1; i >= 0; i--)
            {
                if (i != namesArray.Length - 1) resultLabel.Text += ",";
                resultLabel.Text += namesArray[i];
            }
            resultLabel.Text += "<br /><br />";



            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***


            string ascii = "";
            for (int i = 0; i < namesArray.Length; i++)
            {
                ascii += namesArray[i].PadLeft(((14 - namesArray[i].Length) / 2) + namesArray[i].Length, '*').PadRight(14, '*') + "<br />";
            }
            ascii = ascii.Replace('L', 'l').Replace('H', 'h');
            resultLabel.Text += ascii + "<br />";



            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            puzzle = puzzle.Remove(puzzle.IndexOf("remove-me"), 9).ToLower().Replace('z', 't');
            puzzle = puzzle[0].ToString().ToUpper() + puzzle.Remove(0, 1);
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
            resultLabel.Text += puzzle;

        }
    }
}