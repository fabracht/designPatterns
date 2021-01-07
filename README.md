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
