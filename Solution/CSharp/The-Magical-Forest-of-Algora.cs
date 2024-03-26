using System;
using System.Collections.Generic;

enum DanceMove
{
    Twirl,
    Leap,
    Spin,
    Slide
}

class Creature
{
    public required string Name { get; set; }
    public required List<DanceMove> DanceMoves { get; set; }
}

class Program
{
    private static Dictionary<(DanceMove, DanceMove, DanceMove), string> _effects = new()
    {
        [(DanceMove.Twirl, DanceMove.Twirl, DanceMove.Twirl)] = "A flurry of autumn leaves fills the air.",
        [(DanceMove.Twirl, DanceMove.Twirl, DanceMove.Leap)] = "A soft mist envelops the forest.",
        [(DanceMove.Twirl, DanceMove.Twirl, DanceMove.Spin)] = "A chorus of crickets begins to play.",
        [(DanceMove.Twirl, DanceMove.Twirl, DanceMove.Slide)] = "Fireflies light up the forest.",
        [(DanceMove.Twirl, DanceMove.Leap, DanceMove.Twirl)] = "A gentle breeze rustles the leaves.",
        [(DanceMove.Twirl, DanceMove.Leap, DanceMove.Leap)] = "A rainbow forms in the morning dew.",
        [(DanceMove.Twirl, DanceMove.Leap, DanceMove.Spin)] = "A waterfall appears from nowhere.",
        [(DanceMove.Twirl, DanceMove.Leap, DanceMove.Slide)] = "A flock of birds takes flight.",
        [(DanceMove.Twirl, DanceMove.Spin, DanceMove.Twirl)] = "The forest floor blooms with wildflowers.",
        [(DanceMove.Twirl, DanceMove.Spin, DanceMove.Leap)] = "A gentle rain starts falling.",
        [(DanceMove.Twirl, DanceMove.Spin, DanceMove.Spin)] = "A swarm of butterflies fills the air.",
        [(DanceMove.Twirl, DanceMove.Spin, DanceMove.Slide)] = "A stream begins to babble in harmony with the music.",
        [(DanceMove.Twirl, DanceMove.Slide, DanceMove.Twirl)] = "The air fills with the scent of fresh flowers.",
        [(DanceMove.Twirl, DanceMove.Slide, DanceMove.Leap)] = "A brilliant light illuminates the forest.",
        [(DanceMove.Twirl, DanceMove.Slide, DanceMove.Spin)] = "The forest glows with a soft light.",
        [(DanceMove.Twirl, DanceMove.Slide, DanceMove.Slide)] = "A chorus of forest creatures begins to sing.",
        [(DanceMove.Leap, DanceMove.Twirl, DanceMove.Twirl)] = "A soft glow envelops the forest.",
        [(DanceMove.Leap, DanceMove.Twirl, DanceMove.Leap)] = "A symphony of bird songs fills the air.",
        [(DanceMove.Leap, DanceMove.Twirl, DanceMove.Spin)] = "A cascade of petals falls from the trees.",
        [(DanceMove.Leap, DanceMove.Twirl, DanceMove.Slide)] = "A gentle snow begins to fall.",
        [(DanceMove.Leap, DanceMove.Leap, DanceMove.Twirl)] = "A rainbow appears in the sky.",
        [(DanceMove.Leap, DanceMove.Leap, DanceMove.Leap)] = "A waterfall springs from the ground.",
        [(DanceMove.Leap, DanceMove.Leap, DanceMove.Spin)] = "A gust of wind blows through the forest.",
        [(DanceMove.Leap, DanceMove.Leap, DanceMove.Slide)] = "A chorus of frogs begins to sing.",
        [(DanceMove.Leap, DanceMove.Spin, DanceMove.Twirl)] = "A swarm of bees buzzes in harmony with the music.",
        [(DanceMove.Leap, DanceMove.Spin, DanceMove.Leap)] = "A field of flowers blooms instantly.",
        [(DanceMove.Leap, DanceMove.Spin, DanceMove.Spin)] = "A group of squirrels performs a synchronized dance.",
        [(DanceMove.Leap, DanceMove.Spin, DanceMove.Slide)] = "A group of fireflies begins a light show.",
        [(DanceMove.Leap, DanceMove.Slide, DanceMove.Twirl)] = "A group of mushrooms glow brightly.",
        [(DanceMove.Leap, DanceMove.Slide, DanceMove.Leap)] = "A group of trees sway in time with the music.",
        [(DanceMove.Leap, DanceMove.Slide, DanceMove.Spin)] = "A group of rocks levitate in the air.",
        [(DanceMove.Leap, DanceMove.Slide, DanceMove.Slide)] = "A group of clouds forms a beautiful pattern in the sky.",
        [(DanceMove.Spin, DanceMove.Twirl, DanceMove.Twirl)] = "A constellation of stars appears in the sky.",
        [(DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap)] = "A sudden gust of wind lifts leaves into the air.",
        [(DanceMove.Spin, DanceMove.Twirl, DanceMove.Spin)] = "A group of rabbits perform a synchronized hop.",
        [(DanceMove.Spin, DanceMove.Twirl, DanceMove.Slide)] = "A sudden bloom of flowers covers the forest floor.",
        [(DanceMove.Spin, DanceMove.Leap, DanceMove.Twirl)] = "A group of fish leap out of a stream in a beautiful arc.",
        [(DanceMove.Spin, DanceMove.Leap, DanceMove.Leap)] = "A group of trees bend and sway to the music.",
        [(DanceMove.Spin, DanceMove.Leap, DanceMove.Spin)] = "A group of clouds change shape to form a beautiful scene.",
        [(DanceMove.Spin, DanceMove.Leap, DanceMove.Slide)] = "A group of fireflies spell out a message in the air.",
        [(DanceMove.Spin, DanceMove.Spin, DanceMove.Twirl)] = "A group of birds fly in a mesmerizing pattern.",
        [(DanceMove.Spin, DanceMove.Spin, DanceMove.Leap)] = "A group of butterflies flutter in a beautiful dance.",
        [(DanceMove.Spin, DanceMove.Spin, DanceMove.Spin)] = "A group of deer prance in a circle.",
        [(DanceMove.Spin, DanceMove.Spin, DanceMove.Slide)] = "A group of frogs leap in a synchronized dance.",
        [(DanceMove.Spin, DanceMove.Slide, DanceMove.Twirl)] = "A group of mushrooms suddenly grow and emit a soft glow.",
        [(DanceMove.Spin, DanceMove.Slide, DanceMove.Leap)] = "A group of trees suddenly grow fruit.",
        [(DanceMove.Spin, DanceMove.Slide, DanceMove.Spin)] = "A group of flowers bloom and emit a beautiful fragrance.",
        [(DanceMove.Spin, DanceMove.Slide, DanceMove.Slide)] = "A group of rocks suddenly sparkle with gemstones.",
    };

    static void Main(string[] args)
    {
        var lox = new Creature
        {
            Name = "Lox",
            DanceMoves = [DanceMove.Twirl, DanceMove.Leap, DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap]
        };

        var drako = new Creature
        {
            Name = "Drako",
            DanceMoves = [DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap, DanceMove.Leap, DanceMove.Spin]
        };

        var flix = new Creature
        {
            Name = "Flix",
            DanceMoves = [DanceMove.Slide, DanceMove.Spin, DanceMove.Twirl, DanceMove.Slide, DanceMove.Leap]
        };

        for (int i = 0; i < 5; i++)
        {
            var loxMove = lox.DanceMoves[i];
            var drakoMove = drako.DanceMoves[i];
            var flixMove = flix.DanceMoves[i];

            PrintMove(lox.Name, loxMove);
            PrintMove(drako.Name, drakoMove);
            PrintMove(flix.Name, flixMove);

            Console.WriteLine("");
            Console.WriteLine(_effects.TryGetValue((loxMove, drakoMove, flixMove), out var effect) ?
                $"✨ {effect} ✨":
                "A magical effect happens, but it's hard to describe.");
            Console.WriteLine();
        }
    }

    static void PrintMove(string name, DanceMove move)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{name}");
        Console.ResetColor();
        Console.Write(" performs a ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{move}");
        Console.ResetColor();
        Console.Write(", ");
    }
}