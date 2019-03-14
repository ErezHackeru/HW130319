using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW130319_Exceptions
{
    class MyProtectedUniqueList_T<T> : IEnumerable<T>
    {
        private List<T> words = new List<T>();
        private string _mySecretCode;

        public MyProtectedUniqueList_T(List<T> words, string mySecretCode)
        {
            this.words = words;
            _mySecretCode = mySecretCode;
        }

        public void Add(T w)
        {
            if (w == null)
                throw new ArgumentNullException("The word excepted was null or empty.");
            else if (words.Contains(w))
                throw new InvalidOperationException($"The list already contain this word: {w}");
            else
                words.Add(w);
        }
        public void Remove(T w)
        {
            if (w == null)
                throw new ArgumentNullException("The word excepted was null or empty.");
            else if (!words.Contains(w))
                throw new ArgumentException($"The list does not contain this word: {w}");
            else
                words.Remove(w);
        }

        public void RemoveAt(int indexToRemove)
        {
            if (indexToRemove < 0 || indexToRemove >= words.Count)
                throw new ArgumentOutOfRangeException();
            else
                words.RemoveAt(indexToRemove);
        }
        public void Clear(string SecretCode)
        {
            if (SecretCode == this._mySecretCode)
                words.Clear();
            else
                throw new AccessViolationException();
        }
        public void Sort(string SecretCode)
        {
            if (SecretCode == this._mySecretCode)
                words.Sort();
            else
                throw new AccessViolationException();
        }

        public override string ToString()
        {
            string AllWords = string.Empty;
            for (int i = 0; i < words.Count; i++)
            {
                AllWords += (words[i] + "\n");
            }
            return AllWords;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return words.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return words.GetEnumerator();
        }
    }
}
