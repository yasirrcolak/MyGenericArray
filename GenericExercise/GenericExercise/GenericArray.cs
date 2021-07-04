using System;

namespace GenericExercise
{
    public class GenericArray<T> where T : struct
    {
        /// <summary>
        /// T type array containing items.
        /// </summary>
        private T[] array = new T[2];

        /// <summary>
        /// The number of how many items are in the T-type array containing the items.
        /// </summary>
        private int _itemCount = 0;

        /// <summary>
        /// The number of how many items are in the T-type array containing the items.
        /// </summary>
        public int Count
        {
            get
            {
                return _itemCount;
            }
        }

        #region Public Methods  

        /// <summary>
        /// Array is print to screen.
        /// </summary>
        public void PrintArray()
        {
            if (_itemCount == 0)
            {
                Console.WriteLine("dizi boş\n");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("dizi : " + array[i] + " ");
                }

                Console.WriteLine("\n");
            }
        }

        /// <summary>
        /// This method add item to array. If array is full, call by 'Expand array' method.
        /// </summary>
        /// <param name="input">The item to be appended to the end of aray</param>
        public void Add(T input)
        {
            // Expand array if array is full.
            if (_itemCount >= array.Length)
            {
                // Temporary T type array lenght is array lenght * 2.
                T[] tempArray = new T[array.Length * 2];

                // All items copy to tempArray. 
                for (int i = 0; i < _itemCount; i++)
                {
                    tempArray[i] = array[i];
                }

                array = tempArray;
            }

            array[_itemCount] = input;

            _itemCount++;
        }

        /// <summary>
        /// This method remove first item to array. If array drops below quarter capacity, call by 'Collapse array' method. 
        /// </summary>
        /// <param name="input">The item to be removed from array</param>
        /// <returns>if removed is succesfuly return true. if removed is unsuccesfully return false.</returns>
        public bool Remove(T input)
        {
            // Collapse array if array drops below quarter capacity.
            if (_itemCount <= array.Length / 4)
            {
                // Temporary T type array lenght is array lenght * 2.
                T[] temporaryArray = new T[array.Length / 2];

                // All items copy to tempArray.
                for (int i = 0; i < _itemCount; i++)
                {
                    temporaryArray[i] = array[i];
                }

                array = temporaryArray;
            }

            // It keeps the information whether the item to be deleted is in the array.
            bool findCheck = false;

            // Temporary T type array lenght is array lenght.
            T[] tempArray = new T[array.Length];

            // Contains index value of temporary array in loop.
            int j = 0;

            for (int i = 0; i < _itemCount; i++)
            {
                // if input equals array[i] continue. else array copy to temparray.
                if (array[i].Equals(input) && findCheck == false)
                {
                    findCheck = true;
                    continue;
                }
                else
                {
                    tempArray[j] = array[i];
                    j++;
                }
            }

            array = tempArray;

            _itemCount--;

            if (findCheck == true)
                return true;
            else
                return false;

        }

        /// <summary>
        /// The clear method is used at the remove all items from the array.
        /// </summary>
        public void Clear()
        {
            T[] tempArray = new T[2];

            array = tempArray;

            _itemCount = 0;
        }

        /// <summary>
        /// This method is checks if the entered item is in the array.
        /// </summary>
        /// <param name="input">The item to be find from array.</param>
        /// <returns>if found in array return true. if not found in array return false.</returns>
        public bool Contains(T input)
        {
            for (int i = 0; i < _itemCount; i++)
            {
                if (array[i].Equals(input))
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }

            return false;
        }

        #endregion

    }
}