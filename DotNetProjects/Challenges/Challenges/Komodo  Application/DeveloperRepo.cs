using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo__Application
{
    class DeveloperRepo
    {
        //FakeDatabase
        protected readonly List<Developer> _contentDirectory = new List<Developer>();
        //CRUD
        // CREATE
        public bool AddContentToDirectory(Developer newContent)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(newContent);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // READ
        public List<Developer> GetContents()
        {
            return _contentDirectory;
        }

        public Developer GetContentByDevId(int DevId)
        {
            //get the directory

            //sort through all the items using DevId to find a match
            foreach (Developer content in _contentDirectory)
            {
                if (DevId == content.DevId)
                {
                    return content;
                }
            }
            return null;
        }

        // UPDATE
        public bool UpdateExistingContent(int originalDevId, Developer newContent)
        {
            Developer oldContent = GetContentByDevId(originalDevId);
            if (oldContent != null)
            {
                oldContent.DevName = newContent.DevName;
                oldContent.DevId = newContent.DevId;
                oldContent.HasAcceseToPluralsight = newContent.HasAcceseToPluralsight;
                return true;
            }
            else
            {
                return false;
            }
        }

        // DELETE
        public bool DeleteExistingContent(Developer existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}