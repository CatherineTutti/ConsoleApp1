using System;


namespace ArrayListHW
{
    public class ArrayList
    {
        private int _currentLenght;
        private int[] _array;

        //3 конструктора
        //пустой
        //один элемент
        //массив
        public ArrayList()
        {
            _currentLenght = 0;
            _array = new int[10];
        }

        public ArrayList(int value)
        {
            _currentLenght = 1;
            _array = new int[10];
            _array[0] = value;
        }
        public ArrayList(int[] array)
        {
            _array = new int[10];
            _currentLenght = 1;
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
            _currentLenght += array.Length;
        }

        //узнать количество элементов в списке  GetLengh
        //Вернёт хранимые данные в виде массива  ToArray
        //

        //добавыления значения 
        public void AddLast(int value)
        {
            if (_currentLenght == _array.Length)
            {
                Add();
            }
            _array[_currentLenght] = value;
            _currentLenght++;
        }
        public void Add()
        {
            int newLenght = (int)(_array.Length * 1.33d + 1);
            int[] tmpArray = new int[newLenght];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        //добавление значения в начало списка
        ArrayList = new ArrayList(new int[]{1,2,3 });
        public void AddFirst(ArrayList List)
        {
            for (int i = 0; i < _array.Length; i++)
            {


            }

        }

        //добавления значения по индексу
        public void AddAt (int value)
        {

        }
        //Set   поменять значение элемента с указанным индексом
        public void Set(int value)
        {

        }


        //Удаление первого элемента    RemoveFirst
        //Удаление последнего элемента   RemoveLast
        //Удаление по индексу   RemoveAt
        //Удаление первых n элементов    RemoveFirstMultiple(int n)
        //Удаление последних n элементов RemoveLasttMultiple(int n)
        //Удаление n элементов, начиная с указанного индекса RemoveAttMultiple(int idx, intn)
        //RemoveFirst(int val) - удалить первый попавшийся элемент, значение которого равно val (вернуть индекс удалённого элемента)
        //RemoveAll(int val) - удалить все элементы, равные val (вернуть кол-во удалённых элементов)
        // IndexOf(int val) - вернёт индекс первого найденного элемента, равного val(или -1, если элементов с таким значением в списке нет)
        //GetFirst() - вернёт значение первого элемента списка
        //GetLast() - вернёт значение последнего элемента списка
        //Get(int idx) - вернёт значение элемента списка c указанным индексом
        //Reverse() - изменение порядка элементов списка на обратный
        //Max() - поиск значения максимального элемента
        //Min() - поиск значения минимального элемента
        //IndexOfMax() - поиск индекс максимального элемента
        //IndexOfMin() - поиск индекс минимального элемента
        //Sort() - сортировка по возрастанию
        //SortDesc() - сортировка по убыванию



    }
}
