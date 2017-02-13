#LINK FOR REVIEW-DOCUMENT
https://github.com/Flazhed/TriangleSP/blob/master/Static%20Test%20Techniques%20Exercise%20-%20S%C3%B8ren%20Larsen.pdf

# TriangleSP

Test Case | Input | Expected | Output
--------- |-------|--------|---------
Test for Scalene/Is triangle |8,6,4 | 3 | 3
Test for invalid triangle |8,6,80 | 0 | 0
Test for isoceles (A,B) |4,4,3 | 2 | 2
Test for isoceles (A,C) |4,3,4 | 2 | 2
Test for isoceles (B,C) |3,4,4 | 2 | 2
Test for equilateral |10,10,10 | 1 | 1
Test for negative input |4,4,-3 | -1 | -1
Test for zero input |4,4,0 | -1 | -1
Test for decimal input |4,4,4.0 | -1 | -1
Test for string input |4,4,"four" | -1 | -1
Test for special character input |4,4,% | -1 | -1
