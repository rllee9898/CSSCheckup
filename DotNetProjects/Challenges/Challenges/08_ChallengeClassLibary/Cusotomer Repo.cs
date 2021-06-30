using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ChallengeClassLibary
{
    class Cusotomer_Class
    {
        //FakeDatabase
        protected readonly List<ClassLibary> _contentDirectory = new List<ClassLibary>();
        //CRUD
        // CREATE
        public bool AddContentToDirectory(ClassLibary newContent)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(newContent);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // READ
        public List<ClassLibary> GetContents()
        {
            return _contentDirectory;
        }

        public ClassLibary GetContentByTitle(string CustLN)
        {
            //get the directory
            //sort through all the items using title to find a match
            foreach (ClassLibary content in _contentDirectory)
            {

                if (content.CustLN.ToLower() == CustLN.ToLower())
                {
                    //I want to return streaming content that matches the title
                    return content;
                }
            }
            return null;
        }
    }
}
