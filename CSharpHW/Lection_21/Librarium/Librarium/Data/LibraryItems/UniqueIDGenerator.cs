using System;

namespace Librarium.Data.LibraryItems
{
    internal class UniqueIDGenerator
    {

        private static UniqueIDGenerator _instance;
     

        private int _uniqueIDCounter = 1;


        private UniqueIDGenerator() { }


        internal static UniqueIDGenerator GetInstance()
        {

            if(_instance == null)
            {
                _instance = new UniqueIDGenerator();
            }

            return _instance;
        }

        internal int GenerateUniqueID()
        {
            return _uniqueIDCounter++;
        }
    }
}
