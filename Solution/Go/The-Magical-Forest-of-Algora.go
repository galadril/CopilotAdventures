package main

import (
	"fmt"
)

type DanceMove int

const (
	Twirl DanceMove = iota
	Leap
	Spin
	Slide
)

type Creature struct {
	Name       string
	DanceMoves []DanceMove
}

type DanceMoveKey struct {
	First  DanceMove
	Second DanceMove
	Third  DanceMove
}

func main() {
	effects := map[DanceMoveKey]string{
		{Twirl, Twirl, Twirl}: "A flurry of autumn leaves fills the air.",
		{Twirl, Twirl, Leap}:  "A soft mist envelops the forest.",
		{Twirl, Twirl, Spin}:  "A chorus of crickets begins to play.",
		{Twirl, Twirl, Slide}: "Fireflies light up the forest.",
		{Twirl, Leap, Twirl}:  "A gentle breeze rustles the leaves.",
		{Twirl, Leap, Leap}:   "A rainbow forms in the morning dew.",
		{Twirl, Leap, Spin}:   "A waterfall appears from nowhere.",
		{Twirl, Leap, Slide}:  "A flock of birds takes flight.",
		{Twirl, Spin, Twirl}:  "The forest floor blooms with wildflowers.",
		{Twirl, Spin, Leap}:   "A gentle rain starts falling.",
		{Twirl, Spin, Spin}:   "A swarm of butterflies fills the air.",
		{Twirl, Spin, Slide}:  "A stream begins to babble in harmony with the music.",
		{Twirl, Slide, Twirl}: "The air fills with the scent of fresh flowers.",
		{Twirl, Slide, Leap}:  "A brilliant light illuminates the forest.",
		{Twirl, Slide, Spin}:  "The forest glows with a soft light.",
		{Twirl, Slide, Slide}: "A chorus of forest creatures begins to sing.",
		{Leap, Twirl, Twirl}:  "A soft glow envelops the forest.",
		{Leap, Twirl, Leap}:   "A symphony of bird songs fills the air.",
		{Leap, Twirl, Spin}:   "A cascade of petals falls from the trees.",
		{Leap, Twirl, Slide}:  "A gentle snow begins to fall.",
		{Leap, Leap, Twirl}:   "A rainbow appears in the sky.",
		{Leap, Leap, Leap}:    "A waterfall springs from the ground.",
		{Leap, Leap, Spin}:    "A gust of wind blows through the forest.",
		{Leap, Leap, Slide}:   "A chorus of frogs begins to sing.",
		{Leap, Spin, Twirl}:   "A swarm of bees buzzes in harmony with the music.",
		{Leap, Spin, Leap}:    "A field of flowers blooms instantly.",
		{Leap, Spin, Spin}:    "A group of squirrels performs a synchronized dance.",
		{Leap, Spin, Slide}:   "A group of fireflies begins a light show.",
		{Leap, Slide, Twirl}:  "A group of mushrooms glow brightly.",
		{Leap, Slide, Leap}:   "A group of trees sway in time with the music.",
		{Leap, Slide, Spin}:   "A group of rocks levitate in the air.",
		{Leap, Slide, Slide}:  "A group of clouds forms a beautiful pattern in the sky.",
		{Spin, Twirl, Twirl}:  "A constellation of stars appears in the sky.",
		{Spin, Twirl, Leap}:   "A sudden gust of wind lifts leaves into the air.",
		{Spin, Twirl, Spin}:   "A group of rabbits perform a synchronized hop.",
		{Spin, Twirl, Slide}:  "A sudden bloom of flowers covers the forest floor.",
		{Spin, Leap, Twirl}:   "A group of fish leap out of a stream in a beautiful arc.",
		{Spin, Leap, Leap}:    "A group of trees bend and sway to the music.",
		{Spin, Leap, Spin}:    "A group of clouds change shape to form a beautiful scene.",
		{Spin, Leap, Slide}:   "A group of fireflies spell out a message in the air.",
		{Spin, Spin, Twirl}:   "A group of birds fly in a mesmerizing pattern.",
		{Spin, Spin, Leap}:    "A group of butterflies flutter in a beautiful dance.",
		{Spin, Spin, Spin}:    "A group of deer prance in a circle.",
		{Spin, Spin, Slide}:   "A group of frogs leap in a synchronized dance.",
		{Spin, Slide, Twirl}:  "A group of mushrooms suddenly grow and emit a soft glow.",
		{Spin, Slide, Leap}:   "A group of trees suddenly grow fruit.",
		{Spin, Slide, Spin}:   "A group of flowers bloom and emit a beautiful fragrance.",
		{Spin, Slide, Slide}:  "A group of rocks suddenly sparkle with gemstones.",
	}

	lox := Creature{
		Name:       "Lox",
		DanceMoves: []DanceMove{Twirl, Leap, Spin, Twirl, Leap},
	}

	drako := Creature{
		Name:       "Drako",
		DanceMoves: []DanceMove{Spin, Twirl, Leap, Leap, Spin},
	}

	flix := Creature{
		Name:       "Flix",
		DanceMoves: []DanceMove{Slide, Spin, Twirl, Slide, Leap},
	}

	for i := 0; i < 5; i++ {
		loxMove := lox.DanceMoves[i]
		drakoMove := drako.DanceMoves[i]
		flixMove := flix.DanceMoves[i]

		printMove(lox.Name, loxMove)
		printMove(drako.Name, drakoMove)
		printMove(flix.Name, flixMove)

		fmt.Println()

		effect, ok := effects[DanceMoveKey{loxMove, drakoMove, flixMove}]
		if ok {
			fmt.Printf("✨ %s ✨\n", effect)
		} else {
			fmt.Println("A magical effect happens, but it's hard to describe.")
		}

		fmt.Println()
	}
}

var danceMoves = map[DanceMove]string{
	Twirl: "Twirl",
	Leap:  "Leap",
	Spin:  "Spin",
	Slide: "Slide",
}

func printMove(name string, move DanceMove) {
	moveName := danceMoves[move]
	if moveName == "" {
		moveName = "Unknown"
	}

	red := "\033[31m"
	yellow := "\033[33m"
	reset := "\033[0m"

	fmt.Printf("%s%s%s performs a %s%s%s, ", red, name, reset, yellow, moveName, reset)
}
