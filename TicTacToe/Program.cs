using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Program {
        static int _player = 1;
        static bool isrunning = true;
        static string[] _array = new string[] { "-", "-", "-",
                                                "-", "-", "-",
                                                "-", "-", "-" };

        static void Main(string[] args) {
            while (true) {
                drawBoard();

                p1move();
                drawBoard();
                if (!isrunning)
                    break;

                p2move();
                drawBoard();
                if (!isrunning)
                    break;
            }
            
            Console.WriteLine("GAME OVER, PLAYER {0} WINS", _player);
            Console.ReadKey();
        }

        static void p1move() {
            _player = 1;
            bool istakingturn = true;
            do {
                char _input = Console.ReadKey(true).KeyChar;
                if (_array[int.Parse(_input.ToString()) - 1] == "-") {
                    _array[int.Parse(_input.ToString()) - 1] = "O";
                    istakingturn = false;
                }
            } while (istakingturn);

            checkWinner();
        }

        static void p2move() {
            _player = 2;
            bool istakingturn = true;
            do {
                char _input = Console.ReadKey(true).KeyChar;
                if (_array[int.Parse(_input.ToString()) - 1] == "-") {
                    _array[int.Parse(_input.ToString()) - 1] = "X";
                    istakingturn = false;
                }
            } while (istakingturn);

            checkWinner();
        }

        static void checkWinner() {
            if (_array[0] == _array[1] && _array[0] == _array[2] && _array[0] != "-")
                isrunning = false;
            if (_array[3] == _array[4] && _array[3] == _array[5] && _array[3] != "-")
                isrunning = false;
            if (_array[6] == _array[7] && _array[6] == _array[8] && _array[6] != "-")
                isrunning = false;
            if (_array[0] == _array[3] && _array[0] == _array[6] && _array[0] != "-")
                isrunning = false;
            if (_array[1] == _array[4] && _array[1] == _array[7] && _array[1] != "-")
                isrunning = false;
            if (_array[2] == _array[5] && _array[2] == _array[8] && _array[2] != "-")
                isrunning = false;
            if (_array[0] == _array[4] && _array[0] == _array[8] && _array[0] != "-")
                isrunning = false;
            if (_array[2] == _array[4] && _array[2] == _array[6] && _array[2] != "-")
                isrunning = false;
        }

        static void drawBoard() {
            Console.Clear();
            Console.WriteLine("It is player {0}'s go", _player);
            Console.WriteLine(_array[0] + _array[1] + _array[2]);
            Console.WriteLine(_array[3] + _array[4] + _array[5]);
            Console.WriteLine(_array[6] + _array[7] + _array[8]);
        }
    }
}
