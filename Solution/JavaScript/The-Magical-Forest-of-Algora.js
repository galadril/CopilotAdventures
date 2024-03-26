const DanceMove = {
    Twirl: 0,
    Leap: 1,
    Spin: 2,
    Slide: 3,
  };
  
  class Creature {
    constructor(name, danceMoves) {
      this.name = name;
      this.danceMoves = danceMoves;
    }
  }
  
  const danceMoves = {
    [DanceMove.Twirl]: "Twirl",
    [DanceMove.Leap]: "Leap",
    [DanceMove.Spin]: "Spin",
    [DanceMove.Slide]: "Slide",
  };
  
  const effects = {
    '0,0,0': "A flurry of autumn leaves fills the air.",
    '0,0,1': "A soft mist envelops the forest.",
    '0,0,2': "A chorus of crickets begins to play.",
    '0,0,3': "Fireflies light up the forest.",
    '0,1,0': "A gentle breeze rustles the leaves.",
    '0,1,1': "A rainbow forms in the morning dew.",
    '0,1,2': "A waterfall appears from nowhere.",
    '0,1,3': "A flock of birds takes flight.",
    '0,2,0': "The forest floor blooms with wildflowers.",
    '0,2,1': "A gentle rain starts falling.",
    '0,2,2': "A swarm of butterflies fills the air.",
    '0,2,3': "A stream begins to babble in harmony with the music.",
    '0,3,0': "The air fills with the scent of fresh flowers.",
    '0,3,1': "A brilliant light illuminates the forest.",
    '0,3,2': "The forest glows with a soft light.",
    '0,3,3': "A chorus of forest creatures begins to sing.",
    '1,0,0': "A soft glow envelops the forest.",
    '1,0,1': "A symphony of bird songs fills the air.",
    '1,0,2': "A cascade of petals falls from the trees.",
    '1,0,3': "A gentle snow begins to fall.",
    '1,1,0': "A rainbow appears in the sky.",
    '1,1,1': "A waterfall springs from the ground.",
    '1,1,2': "A gust of wind blows through the forest.",
    '1,1,3': "A chorus of frogs begins to sing.",
    '1,2,0': "A swarm of bees buzzes in harmony with the music.",
    '1,2,1': "A field of flowers blooms instantly.",
    '1,2,2': "A group of squirrels performs a synchronized dance.",
    '1,2,3': "A group of fireflies begins a light show.",
    '1,3,0': "A group of mushrooms glow brightly.",
    '1,3,1': "A group of trees sway in time with the music.",
    '1,3,2': "A group of rocks levitate in the air.",
    '1,3,3': "A group of clouds forms a beautiful pattern in the sky.",
    '2,0,0': "A constellation of stars appears in the sky.",
    '2,0,1': "A sudden gust of wind lifts leaves into the air.",
    '2,0,2': "A group of rabbits perform a synchronized hop.",
    '2,0,3': "A sudden bloom of flowers covers the forest floor.",
    '2,1,0': "A group of fish leap out of a stream in a beautiful arc.",
    '2,1,1': "A group of trees bend and sway to the music.",
    '2,1,2': "A group of clouds change shape to form a beautiful scene.",
    '2,1,3': "A group of fireflies spell out a message in the air.",
    '2,2,0': "A group of birds fly in a mesmerizing pattern.",
    '2,2,1': "A group of butterflies flutter in a beautiful dance.",
    '2,2,2': "A group of deer prance in a circle.",
    '2,2,3': "A group of frogs leap in a synchronized dance.",
    '2,3,0': "A group of mushrooms suddenly grow and emit a soft glow.",
    '2,3,1': "A group of trees suddenly grow fruit.",
    '2,3,2': "A group of flowers bloom and emit a beautiful fragrance.",
    '2,3,3': "A group of rocks suddenly sparkle with gemstones.",
    '3,0,0': "A group of trees suddenly grow taller.",
    '3,0,1': "A group of flowers suddenly change color.",
    '3,0,2': "A group of rocks suddenly become transparent.",
    '3,0,3': "A group of clouds suddenly take on a beautiful color.",
    '3,1,0': "A group of birds suddenly start singing in harmony.",
    '3,1,1': "A group of butterflies suddenly start flying in a beautiful pattern.",
    '3,1,2': "A group of deer suddenly start prancing in a circle.",
    '3,1,3': "A group of frogs suddenly start leaping in a synchronized dance.",
    '3,2,0': "A group of mushrooms suddenly start glowing in different colors.",
    '3,2,1': "A group of trees suddenly start swaying in time with the music.",
    '3,2,2': "A group of flowers suddenly start blooming and emitting a beautiful fragrance.",
    '3,2,3': "A group of rocks suddenly start sparkling with different colored gemstones.",
    '3,3,0': "A group of clouds suddenly start forming different shapes.",
    '3,3,1': "A group of birds suddenly start flying in a mesmerizing pattern.",
    '3,3,2': "A group of butterflies suddenly start fluttering in a beautiful dance.",
    '3,3,3': "A group of frogs suddenly start leaping in a synchronized dance.",
  };
  
  const lox = new Creature("Lox", [DanceMove.Twirl, DanceMove.Leap, DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap]);
  const drako = new Creature("Drako", [DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap, DanceMove.Leap, DanceMove.Spin]);
  const flix = new Creature("Flix", [DanceMove.Slide, DanceMove.Spin, DanceMove.Twirl, DanceMove.Slide, DanceMove.Leap]);
  
  for (let i = 0; i < 5; i++) {
    const loxMove = lox.danceMoves[i];
    const drakoMove = drako.danceMoves[i];
    const flixMove = flix.danceMoves[i];
  
    printMove(lox.name, loxMove);
    printMove(drako.name, drakoMove);
    printMove(flix.name, flixMove);
  
    console.log();
  
    const effect = effects[`${loxMove},${drakoMove},${flixMove}`];
    if (effect) {
      console.log(`✨ ${effect} ✨`);
    } else {
      console.log("A magical effect happens, but it's hard to describe.");
    }
  
    console.log();
  }
  
  function printMove(name, move) {
    let moveName = danceMoves[move];
    if (!moveName) {
      moveName = "Unknown";
    }
  
    const red = "\x1b[31m";
    const yellow = "\x1b[33m";
    const reset = "\x1b[0m";
  
    console.log(`${red}${name}${reset} performs a ${yellow}${moveName}${reset}, `);
  }