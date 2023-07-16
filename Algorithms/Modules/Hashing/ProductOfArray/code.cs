/* 
O(n) time complexity

We can solve this problem by using two arrays, one to keep track of the product of all numbers to the left of the current index, 
and another to keep track of the product of all numbers to the right of the current index. 
We then multiply these two arrays together to get our result.
*/
int[] ProductExceptSelf(int[] nums) {
    var n = nums.Length;
    var output = new int[n];
    var leftProduct = new int[n];
    var rightProduct = new int[n];

    // Initialize the first element of the left product array to 1
    leftProduct[0] = 1;
    for (int i = 1; i < n; i++) {
        leftProduct[i] = nums[i - 1] * leftProduct[i - 1];
    }

    // Initialize the last element of the right product array to 1
    rightProduct[n - 1] = 1;
    for (int i = n - 2; i >= 0; i--) {
        rightProduct[i] = nums[i + 1] * rightProduct[i + 1];
    }

    // Multiply leftProduct and rightProduct arrays to get the output
    for (int i = 0; i < n; i++) {
        output[i] = leftProduct[i] * rightProduct[i];
    }

    return output;
}

/*
We could further optimize the space complexity to O(1) by reusing the output array for one of the product arrays and a variable for the other. 
The resulting code would look like this:
*/

int[] ProductExceptSelf(int[] nums) {
    var n = nums.Length;
    var output = new int[n];

    output[0] = 1;
    for (int i = 1; i < n; i++) {
        output[i] = nums[i - 1] * output[i - 1];
    }

    int rightProduct = 1;
    for (int i = n - 1; i >= 0; i--) {
        output[i] = output[i] * rightProduct;
        rightProduct *= nums[i];
    }

    return output;
}
