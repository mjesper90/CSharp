
# Table of Content
- [Table of Content](#table-of-content)
- [Methods](#methods)
  - [Software Development Lifecycle (SDLC)](#software-development-lifecycle-sdlc)
    - [Agile and Water fall](#agile-and-water-fall)
    - [Unified process](#unified-process)
    - [Waterfall](#waterfall)
    - [Agile sprinting](#agile-sprinting)
  - [User stories](#user-stories)
  - [Actors](#actors)
  - [Usecases](#usecases)
  - [MuSCoW](#muscow)
- [Software Requirement Specification](#software-requirement-specification)
  - [Actors](#actors-1)
  - [Usecase diagram](#usecase-diagram)
  - [MuSCoW prioritized requirements](#muscow-prioritized-requirements)
- [Software Design](#software-design)
- [Plan Template](#plan-template)
  - [Sprint 1 (09/08/2022 - 09/09/2022)](#sprint-1-09082022---09092022)
    - [Requirements](#requirements)
    - [Design and implement](#design-and-implement)
    - [Tests](#tests)
    - [Review](#review)
  - [Sprint 2 (dd/mm/yyyy - dd/mm/yyyy)](#sprint-2-ddmmyyyy---ddmmyyyy)
    - [Requirements](#requirements-1)
    - [Design and implement](#design-and-implement-1)
    - [Test](#test)
    - [Review](#review-1)
  - [Sprint 3 (dd/mm/yyyy - dd/mm/yyyy)](#sprint-3-ddmmyyyy---ddmmyyyy)
    - [Requirements](#requirements-2)
    - [Design and implement](#design-and-implement-2)
    - [Test](#test-1)
    - [Review](#review-2)
- [Your assignment](#your-assignment)

# Methods

## Software Development Lifecycle (SDLC)

There exists many approaches to "lifecycles" in software, two of the most famous is the Agile and Waterfall.

[List of other SDLC's](https://www.tutorialspoint.com/sdlc/)

### Agile and Water fall
![AgileAndWaterfall](Media/AgileAndWaterfall.jpg)

### Unified process
![UnifiedProcess](Media/UP.png)

### Waterfall

The Waterfall Model was the first Process Model to be introduced. It is also referred to as a linear-sequential life cycle model. It is very simple to understand and use. In a waterfall model, each phase must be completed before the next phase can begin and there is no overlapping in the phases.

### Agile sprinting

Agile SDLC model is a combination of iterative and incremental process models with focus on process adaptability and customer satisfaction by rapid delivery of working software product. Agile Methods break the product into small incremental builds. These builds are provided in iterations. Each iteration typically lasts from about one to three weeks. Every iteration involves cross functional teams working simultaneously on various areas.

[Agile manifesto](https://agilemanifesto.org/)

* Individuals and interactions over processes and tools
* Working software over comprehensive documentation
* Customer collaboration over contract negotiation
* Responding to change over following a plan

![AgileSprints](Media/AgileSprints.jpeg)


## User stories

By telling short stories from the actors point of view, we can better understand expected behaviour of the program and find potential actors.

“As an \<actor>, I \<Want to>, \<so that>.”

* As a player I want to have a farm so that I can pet and feed my animals
* As a farmer I want to have a way to deal with unwelcome animals so that my animals dont get eaten.
* As an animal I want to be fed so that I dont die of hunger.

## Actors

If we go through the user stories, we can identify some actors which helps better define our project and start the design process.

## Usecases

Another way of increasing the quality of your requirement specification is to include a use case diagram.

Usecase diagrams have "actors" and "usecases" and displays how they usecases are connected.


## MuSCoW 
 
 * Must, means that this requirement must be fulfilled! Without the "must" features, the program doesn't make sense for the user of the program.
 * Should, means that this requirement will be next in line, when all the 'musts' are done. The program isnt really ussuable without the "shoulds".
 * Could, means that the requirement/feature is still being thoughtover, and due to uncertainty it is placed as a "could"
 * Want, is the wishfull thinking and for potential later direction with the project


Requirements must abide to the following:
 * Must include atleast 1 actor
 * Must include only 1 MuSCoW priority keyword
 * Must be as short and concise as possible
 * Must not conflict with other requirements
 * Must follow the syntax: 
   * \<The actor> \<MuSCow> \<Requirement description>
 * Must not be duplicate

# Software Requirement Specification

## Actors

 * Player/Farmer
 * Animals
 * Hostile animal
 * Friendly animal

## Usecase diagram
![usecase](RequirementsEngineering/Usecase.png)

## MuSCoW prioritized requirements

 * The player must be able choose between different hostile animals to launch
 * The player must be able to launch a hostile animal with a variable amount of force
 * The animals must not suffer any harm!
 * The player should be able catch the animal after launch
 * The player could be able to relaunch again to move around on a map
 * The player wants to use the launched animal as target practice

# Software Design

![Design](SoftwareDesign/Design.png)


# Plan Template

## Sprint 1 (09/08/2022 - 09/09/2022)

### Requirements

Copy/paste result of current requirement specification based on the analysis + changes.

### Design and implement

Jesper will be implementing:

![SimpleDesign](SoftwareDesign//SimpleDesignSprint1.png)

The full design can be found updated in the Software Design chapter.

### Tests

 * Test 1
   * Instructions
     * Click on the wolf and hold 
     * Drag the wolf ontop of the launcher
     * (Optional)Let go of mouse button
   * Acceptance criteria
     * Wolf is sent flying when it touches the launcher.
     * Wolf is not harmed

### Review

Jonas reviewed the implementation, which was a perfect resseamble of the design.
The test was easy to follow, and the acceptance criterias held.

After short discussion, agreed to include addtional 'musts' for next sprint as there was plenty of time left.

Requirement changes:
 
 * The player could be able to relaunch again to move around on a map
  
  After a talk with the someone from the target audience, this requirement does not seem to be important any longer. So it's been removed. or changed? Your choice.

## Sprint 2 (dd/mm/yyyy - dd/mm/yyyy)

### Requirements

### Design and implement

### Test

### Review 

## Sprint 3 (dd/mm/yyyy - dd/mm/yyyy)

### Requirements

### Design and implement

### Test

### Review

# Your assignment

Based on earlier lessons and assignments you should by now have some of the above design already implemented. I have created an example chapter regarding requirements that could lead to the design you have implemented so far.

Your job now is to to implement the rest of the design! After this assignment we will look into Unity, were we can add some graphics, animations and interactions to the program and continue working on our project!

Changing the requirements, design and implementation to better match your own ideas is strongly encouraged!

OBS. I have included 3 classes (PrentendUnity namespace and folder) which demonstrates our initial approach as Programmers to the unity engine. 