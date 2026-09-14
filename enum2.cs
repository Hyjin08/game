using System;
using System.Text;

public class Enum
{
    enum Month
    {
        Jan,
        Fab,
        March,
        April,
        May
    }
    enum GameState
    {
        Title, Menu=100, Option, Game=200, LoadGame,
        Exit=300, Quit
    }
    static void Main(string[] args)
    {
        Month my_mon;
        Month cur_mon;

        my_mon = Month.Jan;
        cur_mon = (Month)3;
        Console.WriteLine("달력의 월: {0}, 현재 월: {1}", my_mon, cur_mon);
        Console.WriteLine("세팅된 월 숫자 {0}", (int)my_mon);
        Console.WriteLine("현재 월 숫자 {0}", (int)cur_mon);

        GameState gamestate;
        gamestate = GameState.Title;
        while (gamestate != GameState.Quit) {
            switch(gamestate) {
                case GameState.Title:
                    Console.WriteLine("타이틀 출력, 현상태" + gamestate);
                    gamestate = GameState.Game;
                    break;
                case GameState.Game:
                    Console.WriteLine("게임 화면 출력, 현상태" + gamestate);
                    gamestate = GameState.Game;
                    break;
                case GameState.Exit:
                    Console.WriteLine("게임 종료, 현상태" + gamestate);
                    gamestate = GameState.Game;
                    break;
            }
}       