# Kata Text Processing

As a developer who writes blogs, I want a tool that helps me better understand the text I am drafting. For this, I need a tool that allows me to know the following:

- What are the most used words in the text?
- How many characters does the text have?

```java
  interface Processor {
     analyse(text: String);
  }
```
It is not necessary to use this interface.

### First Challenge
Given the following text:

```
Hello, this is an example for you to practice. You should grab this text and make it as your test case.
```

The output should be:

Those are the top 10 words used:

1. you
2. this
3. your
4. to
5. text
6. test
7. should
8. practice
9. make
10. it

The text has in total 21 words

#### Some Observations
As you may have noticed, the example assumes that 'You' and 'you' are the same, that is, it does not distinguish between uppercase and lowercase.
Words that have the same count are not in order. For example, 'this' and 'it' appear once, and are not alphabetically ordered.
Next, the kata begins to get a little more complex. Make sure to complete this challenge before moving on to the second.

### Second Challenge
Now I would like to know how long it would take a user to read my post, for this I should apply the following formula:

(The average reading speed is 238, according to this study, but 200 is a good compromise and easier to remember).

Here is the formula:

- Get the total number of words (including the headline and subtitle).
- Divide the total number of words by 200. The number before the decimal is the minutes.
- Take the decimals and multiply it by 0.60. This will give you the seconds.
  Example:

```
783 words ÷ 200 = 3.915 (3 = 3 minutes)
.915 × .60 = .549 (a little over 54 seconds, so I'd bump it up to 60 seconds, or a full minute).
```

The reading time for this article is 4 minutes.

### Third Challenge
In addition to the above features, text processing must also have:

- A way to ignore a certain part of the text for analysis (For example, a snippet of code - the code snippet is found between `javascript` anything inside should be ignored).
- A way to offer keywords and eliminate them from the analysis.
  Given the example from 1, this would be a text with code fragments:

```
Hello, this is an example for you to practice. You should grab this text and make it as your test case:

if (true) {
console.log('should should should')
}
```

The text processing output should ignore the code fragment. That is, the output should be:

Those are the top 10 words used:

1. you
2. this
3. your
4. to
5. text
6. test
7. should
8. practice
9. make
10. it

The text has in total 21 words

Notice that the word 'should' is the same, and it does not rise in the list since 'should' appears four times (more than the word 'you').