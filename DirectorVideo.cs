using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    [Serializable]
    class DirectorVideo:IFilme
    {
        public List<FisierVideo> listVideo = new List<FisierVideo>();
       

        public List<FisierVideo> ListVideo
        {
            get { return listVideo; }
            set { listVideo = value; }
        }

        public DirectorVideo(List<FisierVideo> ls)
        {
            listVideo = ls;
        }
        public DirectorVideo()
        {

        }

        public string afiseazaFilme()
        {
            String filme=null;   
            foreach (FisierVideo f in listVideo)
            {
                filme =filme+f.Denumire; 
            }
            return filme;
        }
    
    }
}
