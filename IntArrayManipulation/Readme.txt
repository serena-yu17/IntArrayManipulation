# C# .NET Web Developer coding assessment

**[About Test]**

- Overview
  - Implement the following RESTful endpoints.
  - Try to finish under 1 hour ( you can spend bit more minutes)
  - Submit
    - Your gitHub
    - Or any public cloud storage
    - Or zip and email
- Technical Environment
  - NET Web Api
  - Or Asp.NET MVC Core
  - Visual Studio 2015 Or 2017 compatible
- Assessment Point
  - Separation of concern
  - Precise Input &amp; Output
  - Code Readability and consistency

**[Questions]**

- Question 1
  - Browser Input /api/arraycalc/reverse?productIds=1&amp;productIds=2&amp;productIds=3&amp;productIds=4&amp;productIds=5
  - Browser Result

[5,4,3,2,1]

-
  - Condition
    - Implement with pure array manipulation
    - Don&#39;t use Array.reverse() method
    - Don&#39;t use Linq
- Question 2
  - Browser Input /api/arraycalc/deletepart?position=3&amp;productIds=1&amp;productIds=2&amp;productIds=3&amp;productIds=4&amp;productIds=5
  - Browser Result

[1,2,4,5]

-
  - Condition
    - Implement with pure array manipulation
    - Don&#39;t use RemoveAt
    - Don&#39;t use Linq