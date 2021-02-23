# Parrot Refactoring Kata
=======================
This refactoring problem has been created by [Kate] (https://github.com/emilybache) and can be found [here](https://github.com/emilybache/Parrot-Refactoring-Kata)

Can you spot any code smells in this code? I'll give you a clue - a spot of Pol(l)ymorphism should improve matters!

Refactor this code, take small steps, run the tests often. See how small and beautiful you can make it.

Acknowlegements
---------------

This code is heavily inspired by one of the examples in Martin Fowler's book "Refactoring". It's a classic, and if it's not on your bookshelf already I suggest you treat yourself to a copy!


## Exercise
### 1. Make a copy of the code (you will use this copy in step 6).
### 2. Identify a code smell i.e. something you would like to improve in the code.

**Code smells identified**
* Switch Statement
The switch statement in GetSpeed() is not practices because it might have to be copy pasted in to other future functions. 

* Data Clumps
Not all private parameters are used in every instance of the parrot class.

* Temporary field
Not all types of parrots need the same amount of parameters to me created. Meaning that some parameters is left empty/set to 0 when constructing a parrot. 

### 3. Decide on a refactoring. You can use the cheat sheet [here] (https://www.industriallogic.com/blog/smells-to-refactorings-cheatsheet/)

Switch Statement and Data Clumps can be fixed using polymorphism. Creating a new class for each parrot type.
<img src="./diagram.png" alt="Class Diagram" width="738">

### 4. Perform the refactoring.
Refactoring has been done.

### 5. Run the test suite and confirm that all tests still pass.
The test has been edited to use Parrot.Create to create instances of the parrot classes.

### 6. Reflect on the new version of the code. What is better/worse than the previous version?
The solution still suffers from Temporary Field in the create function. The parameters now have default values.

### Repeat from step 1.
