# "The Magical Forest of Algora" Adventure

## Table of Contents
- [Agenda](#agenda)
- [Setup](#setup)
- [The Magical Forest of Algora](#the-magical-forest-of-algora)
  - [Introduction](#introduction)
  - [Objective](#objective)
  - [Specifications](#specifications)
    - [Dance Moves and Effects](#dance-moves-and-effects)
    - [Dance Dynamics](#dance-dynamics)
    - [Dance Sequence](#dance-sequence)
    - [Creature Moves](#creature-moves)
    - [Advanced Features (if time permits)](#advanced-features-if-time-permits)
    - [Constraints](#constraints)
    - [Summary of High-Level Tasks to Perform](#summary-of-high-level-tasks-to-perform)
    - [Tips to Get Started](#tips-to-get-started)
  - [GitHub Copilot Tips](#github-copilot-tips)
- [Start Coding](#start-coding)
- [Submit Your Solution](#submit-your-solution)
- [Intel](#intel)

  
## Agenda

### Prerequisites:
- Active Github account
- Copilot license that has been shared with you is already linked to your account
- Wifi is connected, internet is working

If you do not have any of the above, pair up with someone that does have everything working.


### Time Table:

| Activities | Duration  | 
| -------- | -------- | 
| Gather, grab coffee, pair up & set up | 10 mins | 
| Learn about Copilot | 5 mins | 
| Explain Assignment | 5 mins  | 
| Code! | 45 mins | 
| Demos & group discussion | 15 mins|

### Setup

To get started, enter by clicking the button below. This will create a GitHub Codespace that you can work in. Once it loads select the Create codespace button. 

[![Enter Adventure Arena](https://img.shields.io/static/v1?style=for-the-badge&label=Enter+Adventure+Arena&message=Open&color=brightgreen&logo=github)](https://github.com/codespaces/new?hide_repo_select=true&skip_quickstart=true)

## The Magical Forest of Algora

<a href="#">
    <img src="Images/algora-forest.jpg" style="width: 830px" />
</a>

### Introduction

Deep within the enchanted Forest of Algora, two mystical creatures, the Lox and the Drako, perform a sacred dance every millennium. This dance is not just for celebration but is a ritual to bring balance to the forest.

### Objective

Your task is to simulate the dance between Lox and Drako. Each creature has its own set of dance moves, and the combination of moves creates various magical effects in the forest. Your goal is to determine the state of the forest after the dance is complete.

### Specifications

#### Dance Moves and Effects:

- Each creature can perform one of these dance moves: `Twirl`, `Leap`, or `Spin`.
- Combination of moves from both creatures result in magical effects:
  - Twirl + Twirl = Fireflies light up the forest.
  - Leap + Spin = Gentle rain starts falling.
  - Spin + Leap = A rainbow appears in the sky.
  - Other combinations create different effects that you can dream up.

#### Dance Dynamics:

- Each effect will change the state of the forest.
- Some effects can be beneficial, while others can be detrimental.

#### Dance Sequence:

- The dance consists of 5 sequences.
- You need to display the state of the forest after each sequence.

#### Creature Moves:
**Moves for Lox (Creature 1)**

| Sequence 1 | Sequence 2 | Sequence 3 | Sequence 4 | Sequence 5 |
|------------|------------|------------|------------|------------|
| Twirl | Leap | Spin | Twirl | Leap |

**Moves for Drako (Creature 2)**


| Sequence 1 | Sequence 2 | Sequence 3 | Sequence 4 | Sequence 5 |
|------------|------------|------------|------------|------------|
| Spin | Twirl | Leap | Leap | Spin |


#### Advanced Features (if time permits):
    - Implement a system that allows users to add new characters, dance moves and effects.
    - Users can select the dance move for each sequence.
    - Implement speech-to-text for selecting dance moves using Azure Speech Services.
    - Visualize the forest using Azure AI DALLE-3.
    - Animate visualizations if the above is not challenging enough.

#### Constraints

- Use GitHub Copilot and write the simulation in any language you'd like.
- Focus on clear and concise code that handles the dance dynamics efficiently. Ask GitHub Copilot/Chat, "How can I make this code more readable and maintainable?".
- Creating a visual representation for the dance and effects is optional but encouraged if you have time.

### Summary of High-Level Tasks to Perform

1. Use a console application to render the output.
1. Initialize the state of the forest.
1. Each creature selects a dance move for each sequence.
1. Determine the effect of the combined dance moves on the forest.
1. Update the state of the forest after each sequence.
1. Display the final state of the forest after the dance is complete.

### Tips to Get Started

1. If you're using a GitHub Codespace, you're ready to go!
1. If running locally, ensure that you have your target language/framework installed. 
    - [Node.js](https://nodejs.org)
    - [Python](https://www.python.org/downloads/)
    - [.NET](https://dot.net)
1. Create a folder for your code. 
    - JavaScript: Create a folder called `algora` and add a file named `app.js`.
    - Python: Create a folder called `algora` and add a file named `app.py`.
    - C#: Create a folder called `algora` and run `dotnet new console`.

### GitHub Copilot Tips

<a href="#">
    <img src="Images/copilot-tips.jpg"  style="width: 830px" />
</a>

#### Use Copilot to improve efficiency

See if you can use Copilot to find out the complexity (BigO notation) of the code.

1. Open the [GitHub Copilot Chat view](https://docs.github.com/en/copilot/github-copilot-chat/using-github-copilot-chat#asking-your-first-question) in the sidebar if it's not already open. Make sure your solution file is still open as well.

1. Ask Copilot Chat what the complexity of the code is.

1. Ask Copilot Chat to make the code more efficient.

1. Ask for the complexity again - is it better?

#### Use Copilot to generate code comments

1. Highlight all of the code with <kbd>Ctrl</kbd>/<kbd>Cmd</kbd>+<kbd>A</kbd>.

1. Press <kbd>Ctrl</kbd>/<kbd>Cmd</kbd>+<kbd>I</kbd> to open the inline chat. 

1. Type "/doc"

1. Ask Copilot Chat to document the function.

#### Use Copilot to simplify your code

1. Open GitHub Copilot Chat in the sidebar.

1. Type "/simplify" and press <kbd>Enter</kbd>. You can also add any text you want after the "/simplify" to give Copilot more instructions.

1. What did Copilot Chat suggest you do to make it simpler?

#### Got Errors?

Copilot Chat can help with that too! Just copy the error message and paste it into Chat. Often that's all Copilot needs to resolve your issue.

## Start Coding

Read Your Copilot Adventure description, the high-Level tasks to perform, and the GitHub Copilot hints to help you write your code.

- Use [GitHub Copilot](https://docs.github.com/en/copilot/getting-started-with-github-copilot) and/or [GitHub Copilot Chat](https://docs.github.com/en/copilot/github-copilot-chat/using-github-copilot-chat) to help you write the code for the adventure. You can use any language you'd like. Try learning a new language if you're up for the challenge (more on that below)!
- Leave any comments in your code to explain your thought process and show prompts that GitHub Copilot used to help you out.

## Submit Your Solution

If you'd like to share your solution with others, perform the following steps:

- Publish your adventure solution to a GitHub repo. 
- Visit https://github.com/snw55/CopilotAdventures/issues and select `New Issue`.
- Add a link to your GitHub repo in the body section.
- If you have any feedback, share what you found (good or bad). We'd love to hear your feedback!

## Intel

- Try and only use your Codespace and Copilot
- Questions or stuck? Ask us!
- Example solutions can be found in `/Solutions` folder
- Copilot shortcuts
  - `CTRL` - `SHIFT` - `I`: Workspace prompt
  - `CTRL` - `I`: Inline prompt, also works on code selection.
- Copilot commands
  - /doc /explain /fix /generate /help /optimize /simplify /tests
- Azure Speech: key/region
- Azure AI DALLE-3: endpoint/key
