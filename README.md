# Design Patterns study guide

## Purpose

This repository serves as a study guide to Design Patterns in C#

## Contents

Each folder is named after the design patterns implemented there. The code is commented and organized in such a way that you should be able to run the project from the getgo.
Some design patterns contain properties or methods that are there to illustrate a point. For example:

- The singletonPattern1 implementation provides a static variable that shows one of the caveats to that particular design.

## How to run

Each folder is a dotnet console project.
To run the projects do:

```
$ cd $PROJECT_NAME
$ dotnet run
```

WARNING WINDOWS USERS: Console applications in windows close immediately after they finish running. If you are running dotnet on windows, add a Console.Read() to the end of each Main() for each project.

## Where would you use such implementations? Here are some basic but useful topics to remember about each design.

### Singleton

-     When working with a centralized system (for example a database)
-     When maintaining a common log file
-     When maintaining a thread pool in a multithreaded environment
-     When implementing a caching mechanism or device drivers, and so forth

### Prototype with Factory

Shallow copy version. (MemberwiseClone version)

#### Some observations on the advantages of using this pattern

-     Whenever you don't want to modify the existing object, you can clone it and experiment on that.
-     You can include and discard products easily
-     You can focus on the key activities rather than focusing on complicated instance creation processes.

There are some caveats to the this pattern.

- Each subclass needs to implement the cloning or copying mechanism
- If the object doesn't support copying, things can get tricky.
