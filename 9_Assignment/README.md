
# Software Requirement Specification

## Methods

### User storie(s)

 * The player choses to launch an animal in a direction with a certion amount of force 
 * The player catches the launched animal
 * The animals can run off if the are left alone for too long
 * The player 

### Actors

 * Player
 * Animals

### MuSCoW prioritization
 
 * Must, means that this requirement must be fulfilled! Without the "must" features, the program doesn't make sense for the user of the program.
 * Should, means that this requirement will be next in line, when all the 'musts' are done. The program isnt really ussuable without the "shoulds".
 * Could, means that the requirement/feature is still being thoughtover, and due to uncertainty it is placed as a "could"
 * Want, is the wishfull thinking and for potential later direction with project

## MuSCoW prioritization

 * The player must be able choose between different animals to launch
 * The player must be able to launch an animal with a variable amount of force in a 3-dimensional direction
 * The animals must not suffer any harm!
 * The player should be able catch the animal
 * The player could be able to relaunch again to move around on a map
 * The player want to use the launched animal as target practice

## 

# Design

![asd](design.png)



# Inheritance and interfaces assignment!
Create a "FriendlyAnimal" Class that should inherit from "Animal"
Refactor the Pig/Dog class to inherit from FriendlyAnimal
FriendlyAnimal must implement FriendlyAnimalInterface
Create a "HostileAnimal" Class that inherits from "Animal"
Create a Lion and an Alligator class that inherits from HostileAnimal
HostileAnimal must implement the HostileAnimalInterface
See the "CurrentDesign" and "FinishedDesign" files!
