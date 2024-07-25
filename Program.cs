//*****************************************************************************
//** 35. Search Insert Position leetcode                                     **
//** For loop with an if statement, beats 100% in C                     -Dan **
//*****************************************************************************


int searchInsert(int* nums, int numsSize, int target) {
    for (int i = 0; i < numsSize; i++)
    {
//        printf("target = %d and nums[%d]=%d\n",target,i,nums[i]);
        if((target == nums[i])||(target < nums[i])) return i;
    }
    return numsSize;
}