using System;
using System.Runtime.Serialization;

namespace Librarium.Data.LibraryItems
{
    [Serializable]
    public class UniqueIDGenerator : ISerializable
    {
        
        private static UniqueIDGenerator _instance;


        public int UniqueIDCounter { get; set; }


        private UniqueIDGenerator() 
        {
        }


        static UniqueIDGenerator()
        {
            _instance = new UniqueIDGenerator();
        }

        public static UniqueIDGenerator GetInstance()
        {
            return _instance;
        }

        public int GenerateUniqueID()
        {
            return UniqueIDCounter++;
        }

        public void SetUniqueID(int id)
        {
            UniqueIDCounter = id;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.SetType(typeof(UniqueIDGeneratorHelper));
        }


        private class UniqueIDGeneratorHelper : IObjectReference
        {
            public object GetRealObject(StreamingContext context)
            {
                return UniqueIDGenerator.GetInstance();
            }
        }
    }
}
