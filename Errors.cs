using System;
using System.Runtime.Serialization;

namespace StudentsХml
{
    [Serializable]
    internal class StudentIsNullExeption : Exception
    {
        public StudentIsNullExeption()
        {
        }

        public StudentIsNullExeption(string message) : base(message)
        {
        }

        public StudentIsNullExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StudentIsNullExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}