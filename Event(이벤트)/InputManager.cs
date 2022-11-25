using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;

        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A || info.Key == ConsoleKey.Q)
            {
                // 모두한테 알려준다!
                InputKey();
            }
        }
    }
}
