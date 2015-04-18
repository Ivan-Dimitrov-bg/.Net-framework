using System;
using System.Text;

    class GenericList<T> where T : IComparable<T>
    {
        private T[] components;       

        public GenericList(int i)
        {
            this.components = new T[i];
        }

        public T IndexAccess(int i)
        {
            return components[i];
        }

        public void Remove(T[] example, int index)
        {           
            for (int i = index; i < example.Length - 1; i++)
            {
                example[i] = example[i + 1];
            }
        }

        public void Add(T[] example, int index, T input)
        {
            for (int i = example.Length - 1; i > index; i--)
            {
                example[i] = example[i - 1];
            }
            example[index] = input;
        }

        //6 задача
        public void Double(T[] example)
        {
            T[] twice = new T[2 * example.Length];
            for (int i = 0; i < example.Length; i++)
            {
                twice[i] = example[i];
            }
        }

        // Колега това по-долу е неуспешния ми опит да clear  списъка ако ти си успял/а сподели 
        /*public void Clear(T[] delete)
        {
            for (int i = 0; i < delete.Length; i++)
            {
                delete[i] = null;
            }
        } */

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < components.Length; i++)
            {
                sb.Append(components[i].ToString());
                sb.Append(' ');
            }
            return sb.ToString();
        }

        // 7 задача
        public T Max (T[] example)
        {
            T maximum = example[0];
            for (int i = 1; i < example.Length; i++)
            {
                if (maximum.CompareTo(example[i]) < 0)
                {
                    maximum = example[i];
                }
            }
            return maximum;
        }

        public T Min(T[] example)
        {
            T minimum = example[0];
            for (int i = 1; i < example.Length; i++)
            {
                if (minimum.CompareTo(example[i]) > 0)
                {
                    minimum = example[i];
                }
            }
            return minimum;
        }
    
    }