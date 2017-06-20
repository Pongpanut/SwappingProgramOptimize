This version I have get rid of the dynamic programming logic after I found that It doesn't help to reduce the complexity of the Logic

So I found new solution by reducing the number of iteration from O(kn) to O(n % (k-1)) [if k is number of operation amount and n is number of iteration amount] and found this way provided better result


Example if user put "16 1000000000" as the operation amount and iteration amount
given 16 is k and 1000000000 is n
Previous version's complexity is O(kn) that mean 16000000000 iterations.
Optimized version's complexity is O(n%(k-1)) mean 10 iterations.

Please find the screenshot in this repository

Note : This is the logic that i have add to reduce iteration 
       "var newIter = (iterAmt % (operationAmt-1));"
       newIter is optimized iteration (new iteration that I used)
       iterAmt is the original iteration amount
       OperationAmt is number of operaration amount
