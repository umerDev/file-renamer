using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_renamer
{
    class HelperMethods
    {
        private List<string> AllFiles = new List<string>();

        public List<string> AddFilesToList
        {
            get
            {
                return AllFiles.ToList();
            }
            set
            {
                //if (IsDuplicate())
                //{
                //    return;
                //}

                AddFilesToList = value;
            }   
                    
        }

        private bool IsDuplicate()
        {
           var query = AllFiles.GroupBy(x => x)
                    .Where(g => g.Count() > 1)
                    .Select(y => y.Key)
                    .ToList();

            if(Convert.ToInt32(query.ToArray()) > 1)
            {
                Console.WriteLine("Duplicate found");
                return true;
            }
            return false;
        }
    }
}
