# All K-Combinations

This is an IList extension method in C# which generates all [combinations](http://en.wikipedia.org/wiki/Combination) of elements. Specifically, it generates all k-combinations for all k `0..n`

For example, given the collection `{1,2,3}` the method will generate the following 8 combinations:

`{}`

`{1}`

`{2}`

`{1, 2}`

`{3}`

`{1, 3}`

`{2, 3}`

`{1, 2, 3}`

The number of combinations will always be `2^n`. Empty set is a combination for any input. There is no ordering of the results. The return collection is lazy-evaluated; it won't compute the combinations until you iterate over it.

This repository includes a solution, project file, and a main function for demonstration purposes. The actual code of interest is contained in **IListExtensions.cs**

This software is released under the CC0 (public domain) license.