# «Fake It Till You Make It» FizzBuzz Kata

## What are we going to do?
In the whole world of Agile...
![Agile](./Slides/zooming_01.png)

... there are a lot of different techniques.
![Agile Techniques](./Slides/zooming_02.png)

But we will only focus on Test Driven Development.
![Agile: TDD](./Slides/zooming_03.png)

And with in the world of Test Driven Development...
![TDD Techniques](./Slides/zooming_04.png)

... we will only focus on the Refactoring part.
![TDD: Refactoring](./Slides/zooming_05.png)

And within all these Refactoring techniques...
![Refactoring Techniques](./Slides/zooming_06.png)

...we will only focus on «Fake It Till You Make It».
![Refactoring: Fake It Till You Make It](./Slides/zooming_07.png)

And within «Fake It Till You Make It»...
![Fake It Till You Make It: Techniques](./Slides/zooming_08.png)

...we will only focus on Derivation.
![Refactoring: Fake It Till You Make It](./Slides/zooming_09.png)

## FizzBuzz
FizzBuzz from 1 - 20 will give you:

`1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz`

Why doesn't matter. The whole point of this technique is: We are going to make a working program out of this, without knowing why it works, but simply from getting a working example.

It is usually very easy to get a working example from your business partners. But it's remarkably hard to get complete requirements.

## Rules
### Separate
`"18585555555"` vs. `"1" + "8585555555"`

The second one is _less fake_ than the first one. Now I have a `1` I can do something with.

### Encapsulate
`"1" + "8585555555"` vs. `areaCode + "8585555555"`

`1` is _more fake_ than `areaCode`. This tells me «why?».

### Calculate
`"1"` vs. `"" + 1`

A solid hardcoded answer is _less information_ than a calculated answer from data.

### Automate
`numbers = [5,6,7,8,9,10]` vs. `numbers = [5..10]`

If you count form `5` to `10` don't just give me the numbers.

### Clean
🧹