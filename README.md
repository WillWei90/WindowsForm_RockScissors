# Rock Paper Scissors Game (猜拳遊戲)

A Windows Forms application implementing a simple Rock Paper Scissors game where players can compete against a computer opponent.

## Features

### Game Controls
- **Start Button**: Initiates a new game
- **Pause Button**: Temporarily suspends the current game
- **Stop Button**: Ends the current game
- **Quit Button**: Exits the application

### Gameplay Elements
- Timer-based gameplay with 30-second rounds
- Player vs Computer (Rival) format
- Dynamic game state display with outcome indicators
- Real-time countdown timer
- Win/Lose/Draw result tracking

## Technical Implementation

### Development Environment
- **Platform**: Microsoft Visual Studio  
- **Framework**: .NET Framework  
- **UI Framework**: Windows Forms (WinForms)  
- **Programming Language**: C#  

### Key Components

#### Forms and Controls
- **Form Class**: Main game window inheriting from `Form`
- **Button Controls**: Start, Pause, Stop, Quit buttons
- **PictureBox Controls**: For displaying game icons
- **Label Controls**: For displaying timer and game status
- **MessageBox**: For showing game results and notifications

#### Timer Implementation
- **System.Windows.Forms.Timer**:
  - Used for game countdown
  - Interval set to 1000ms (1 second)
  - Handles game state updates
  - Controls round duration

#### Event Handlers
- **Button Click Events**: Handle player actions
- **Timer Tick Event**: Updates countdown and game state
- **Form Load Event**: Initializes game components

#### Game Logic
- Random Number Generation: For computer moves
- State Management: Tracks current game state
- Score Tracking: Maintains win/lose statistics
- Game Rules Engine: Determines win/lose/draw conditions

### UI Elements
- **Layout Management**: `TableLayoutPanel` for structured layout
- **Dynamic Updates**: Real-time UI refresh
- **Resource Management**: Image loading and display
- **State Visualization**: Game status indicators

## Game States

### Initial State
- Form initialization
- Control setup
- Resource loading

### Running State
- Timer active
- Input processing
- State updates

### Paused State
- Timer suspended
- State preservation
- Resume capability

### End State
- Score calculation
- Result display
- Reset preparation

## Best Practices
- Event-Driven Programming
- Object-Oriented Design
- Resource Management
- Error Handling
- User Input Validation

## File Structure
- Form1.cs           # Main form code
- Form1.Designer.cs  # Generated UI code
- Program.cs         # Application entry point
- Resources/         # Game images and assets

## User Interface
- Clean, intuitive layout
- Visual feedback for game states
- Clear status messages
- Easy-to-use control buttons
- Real-time timer display

### Controls Reference
- **Start**: Begin new game
- **Pause/Cont.**: Toggle game pause state
- **Stop**: End current game
- **Quit**: Exit application

## Implementation Notes
- Timer starts at 30 seconds and counts down
- Game states are clearly indicated in the title bar
- Results are tracked and displayed at game end
- Supports full game pause/resume functionality
