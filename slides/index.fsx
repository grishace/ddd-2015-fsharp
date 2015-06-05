(**

- title : Introduction to F# 
- description : Introduction to F#. Denver Dev Day (June 5, 2015)
- author : Grigoriy Belenkiy
- theme : simple
- transition : convex

***

- data-background : images/sponsors.png
- data-background-transition : none

' Sponsors slide (required by organizators)

***

### Introduction to F#

![KeepCalm](./images/keepcalmfsharp.jpg)

<small>Grigoriy Belenkiy<br/>
Software engineer, McGraw Hill Financial
<br/>
<br/>
Denver Dev Day<br/>
June 5, 2015</small>

***

### Agenda

- Why F#?
- Basics
- Advanced features
- More...

***

### Programming Paradigms

- Logic
- Imperative
- Functional

---

#### Logic programming

- Set of sentences (predicates)
- Describe <i>rules</i> of problem domain
- Prolog (1972)

---

#### Imperative programming

- Set of statements (sequence of actions)
- Changes in program state (mutable, shared)
- Describes <i>how</i> program operates 
- FORTRAN (1954), OOP - Simula 67 (1960's)

---

#### Functional programming

- Evaluation of mathematical functions
- Avoids mutable state and side-effects
- Output value depends only on input

***

### Functional programming

- Lambda calculus (1930's)
- Math theory of functions and their evaluation
- Basis of almost all functional programming languages today
- $ f(x) = x^{2} + 2 \;\; \rightarrow \;\; \lambda x.x^{2} + 2 $

' expressing computation by way of variable binding and substitution

---

#### Functional languages

- LISP (1958)
- ML (1973); "impure", multi-paradigm
- Erlang (1986)
- Haskell (1990)
- Scala (2003)
- F# (2005)

' ML - first-class functions (explain), automatic memory management through garbage collection, type inference, pattern matching, and exception handling
' Erlang - Ericsson, network hardware, actors concurrency
' Haskell - math putity
' Scala - JVM, "better Java"
' F# .NET, part of VS2010, Current version 3.1 (2014), 4.0 this year

---

#### Why F#?

- Conciseness
- Convenience
- Correctness
- Concurrency
- Completeness


***

### Hello World

***

### FizzBuzz

>Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.

***

### Factorial

![Product](./images/595efd051707fb0b8c6ad8d2776eea5e.png)

![Recurrence](./images/a91da51a80ac8291d8dbcc4cb77c0936.png)

***

### FizzBuzz (revisited)

***

### Metric mishap caused loss of NASA orbiter

>(CNN) -- NASA lost a $125 million Mars orbiter because a Lockheed Martin engineering team used English [imperial] units of measurement while the agency's team used the more conventional metric system for a key spacecraft operation, according to a review finding released Thursday.

[CNN.com, September 30, 1999](http://www.cnn.com/TECH/space/9909/30/mars.metric.02/)

---

### Units of Measure

- Float, signed int
- Compile-time checking
- Length, volume, mass, and so on... <span class="fragment"> temperature?</span>

***

### Type providers

- CSV
- SQL
- More...

***

### Async

***

### GUI

- WinForms
- WPF

***

### Resources

#### On-line

- F# Foundation ([fsharp.org](http://fsharp.org))
- F# For Fun And Profit ([fsharpforfunandprofit.com](http://fsharpforfunandprofit.com))
- Try F# ([tryfsharp.org](http://www.tryfsharp.org))
- F# Cheatsheet ([dungpa.github.io/fsharp-cheatsheet](http://dungpa.github.io/fsharp-cheatsheet/))

---

#### Books

<table>
  <tr>
    <td><a href="http://www.manning.com/petricek/"><img alt="Real-World Functional Programming With examples in F# and C#" src="./images/rwfp.jpg"/><br/>
    <small><h4>Real-World Functional Programming With examples in F# and C#</a>
    by Tomas Petricek with Jon Skeet</h4></small></td>
    <td><a href="http://www.manning.com/petricek2/"><img alt="F# Deep Dives" src="./images/fsdd.jpg"/><br/>
    <small><h4>F# Deep Dives</a>
    edited by Tomas Petricek and Phillip Trelford</h4></small></td>
  </tr>
  <tr>
    <td><a href="http://shop.oreilly.com/product/9781593275525.do"><img alt="The Book of F#" src="./images/book.jpg"/><br/>
    <small><h4>The Book of F#</a> by Dave Fancher</h4></small></td>
    <td><a href="http://shop.oreilly.com/product/0636920026099.do"><img alt="Building Web, Cloud, and Mobile Solutions with F#" src="./images/web.jpg"/><br/>
    <small><h4>Building Web, Cloud, and Mobile Solutions with F#</a> by Daniel Mohl</h4></small></td>
  </tr>
</table>

***

### That's all!

#### Questions?

[http://grishace.github.io/ddd-2015-fsharp](http://grishace.github.io/ddd-2015-fsharp)

*)
