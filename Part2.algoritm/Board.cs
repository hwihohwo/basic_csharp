using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2.algoritm
{
    class MyList<T>
    {
        const int DEFAULTSize = 1;
        T[] _data = new T[DEFAULTSize];

        public int Count = 0; // 실제로 사용중인 data 개수
        public int Capacity { get { return _data.Length; } } // 예약된 data 개수

        // O(1) 예외 케이스 : 이사 비용은 무시한다.(이사 비용은 특정 경우에만 실행되기 때문...?)
        public void Add(T item)
        {
            // 1. 공간이 충분히 남아 있는지 확인.
            if (Count >= Capacity)
            {
                // 공간을 다시 늘려서 확보한다.
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];
                _data = newArray;
            }

            // 2. 공간에다가 data를 넣어준다.
            _data[Count] = item;
            Count++;
        }

        // O(1)
        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        // O(N)
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T)!; // !는 nullable check를 하지말라는 의미.
            Count--;
        }
    }

    class MyLinkedListNode<T>
    {
        public T? Data;
        public MyLinkedListNode<T>? Next;
        public MyLinkedListNode<T>? Prev;
    }

    class MyLinkedList<T>
    {
        public MyLinkedListNode<T>? Head = null; // 첫번째
        public MyLinkedListNode<T>? Tail = null; // 마지막
        public int Count = 0;

        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
            newRoom.Data = data;

            // 만약에 아직 방이 아예 없었다면, 새로 추가된 방이 head
            if (Head == null)
                Head = newRoom;

            // 기존 마지막과 새로 추가된 방 연결해줌.
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }

            // 새로 추가되는 방을 마지막 방으로
            Tail = newRoom;
            Count++;
            return newRoom;
        }

        public void Remove(MyLinkedListNode<T> room)
        {
            if (Head == room)
                Head = Head.Next;

            if (Tail == room)
                Tail = Tail.Prev;

            if (room.Prev != null) // null체크 안할 시 크래시날수도.
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    }

    class Board
    {
        const char CIRCLE = '\u25cf';
        public TileType[,] Tile { get; private set; } // 배열
        public int Size { get; private set; }

        public int DestY { get; private set; }
        public int DestX { get; private set; }

        Player _player;
        //public MyList<int> _data2 = new MyList<int>(); // 동적 배열
        //public MyLinkedList<int> _data3 = new MyLinkedList<int>(); // 연결 리스트

        public enum TileType
        {
            Empty,
            Wall,
        }

        void GenerateBybinaryTree()
        {
            // 일단 길을 막아버리는 작업.
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    if (x % 2 == 0 || y % 2 == 0)
                        Tile[y, x] = TileType.Wall;
                    else
                        Tile[y, x] = TileType.Empty;
                }
            }

            // 랜덤으로 길을 뚫는 작업
            Random rand = new Random();
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    if (x % 2 == 0 || y % 2 == 0)
                        continue;

                    if (y == Size - 2 && x == Size - 2)
                        continue;

                    if (y == Size - 2)
                    {
                        Tile[y, x + 1] = TileType.Empty;
                        continue;
                    }

                    if (x == Size - 2)
                    {
                        Tile[y + 1, x] = TileType.Empty;
                        continue;
                    }

                    if (rand.Next(0, 2) == 0)
                    {
                        Tile[y, x + 1] = TileType.Empty;
                    }
                    else
                    {
                        Tile[y + 1, x] = TileType.Empty;
                    }
                }
            }
        }

        void GenerateBySideWinder()
        {
            // 길 막는 작업.
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    if (x % 2 == 0 || y % 2 == 0)
                        Tile[y, x] = TileType.Wall;
                    else
                        Tile[y, x] = TileType.Empty;
                }
            }

            Random rand = new Random();
            for (int y = 0; y < Size; y++)
            {
                int count = 1;
                for (int x = 0; x < Size; x++)
                {
                    if (x % 2 == 0 || y % 2 == 0)
                        continue;

                    if (y == Size - 2 && x == Size - 2)
                        continue;

                    if (y == Size - 2)
                    {
                        Tile[y, x + 1] = TileType.Empty;
                        continue;
                    }

                    if (x == Size - 2)
                    {
                        Tile[y + 1, x] = TileType.Empty;
                        continue;
                    }

                    if (rand.Next(0, 2) == 0)
                    {
                        Tile[y, x + 1] = TileType.Empty;
                        count++;
                    }
                    else
                    {
                        int randomIndex = rand.Next(0, count);
                        Tile[y + 1, x - randomIndex * 2] = TileType.Empty;
                        count = 1;
                    }
                }
            }
        }

        public void Initialize(int size, Player player)
        {
            if (size % 2 == 0)
                return;

            _player = player;

            Tile = new TileType[size, size];
            Size = size;

            DestY = Size - 2;
            DestX = Size - 2;

            // Mazes for Programmers

            GenerateBySideWinder();

        }

        public void Render()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    // 플레이어 좌표를 갖고 와서, 그 좌표와 y, x일치하면 플레이어 색상으로.
                    if (y == _player.PosY && x == _player.PosX)
                        Console.ForegroundColor = ConsoleColor.Blue;
                    else if (y == DestY && x == DestX)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = GetTileColor(Tile[y, x]);
                    Console.Write(CIRCLE);
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = prevColor;
        }

        ConsoleColor GetTileColor(TileType type)
        {
            switch (type)
            {
                case TileType.Empty:
                    return ConsoleColor.Green;
                case TileType.Wall:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Green;
            }
        }
    }
}
