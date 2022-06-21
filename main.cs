//Palindrome problem
// A phrase is a palindrome if, it is the same string if it is reversed

// Given a string s, return true if it is a palindrome, or false otherwise.

// Example 1:

// Input: s = "amanaplanacanalpanama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.
// Example 2:

// Input: s = "raceacar"
// Output: false
// Explanation: "raceacar" is not a palindrome.

// Input: s = "cars"
// Output: false


//Input s = "jacaj"
bool IsPalindrome(string input)
{
  int halflength = input.length/2;
  for(int i=0,j=input.length-1;i<halflength;i++,j--)
  {
    if(input[i]!=input[j])
      return false;
  }
  return  true;
}


// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

 

// Example 1:
// 7 l t2 R15 L11
// Input: nums = [11,2,7,15], target = 9
// Output: [0,2]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:

// Input: nums = [3,2,4], target = 7
// Output: [0,2]
// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]

int2 GetTargetSumPair(int[] nums, int target)
{
  for(int i=0;i<nums.length-1;i++)
  {
    if(nums[i])> target)
      continue;
   for(int j=i+1;j<nums.length;j++)
  {
    if(nums[i]+nums[j] == target)
    {
      return new int2(i,j);
    }
  } 
  }
}

// Improved it using trees but took a lot of time and wasn't clear

{2:0, 11:1, 7:2, 15:3}