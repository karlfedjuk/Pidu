using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Pidu
{
    class korter
    {
        private int maksimumSuurus = 10;
        private List<string> inimesed = new List<string>();

        public void lisaInimene(string inimene)
        {
            if (kasmahubVeel()==true)
            {
                inimesed.Add(inimene);
                
            }
            else
            {
                var dialog = new MessageDialog("10 inimest on täis. Rohkem ei mahu");
                dialog.ShowAsync();
            }
            
        }

        
         public void eemaldaInimene(string inimene)
        {
            inimesed.Remove(inimene);
        }


        public Boolean kasmahubVeel()
        {
            Boolean kontroll 
        }

        public string kuvaInimesed()
        {
            string rahvas = "";

            for (int = 0; i < inimesed.count; i++)
            {
                rahvas = rahvas + inimesed[i] + System.Environment.NewLine;
            }

            {
                return inimesed;
            }
        }
    }
    public Boolean kontroll = false;

        if (inimesed.Count < maksimumSuurus)
            {
                kontroll = true;
            }
            
            {
            else
            }
{

}

            return kontroll
    }
}