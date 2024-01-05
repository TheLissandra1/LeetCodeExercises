Solution 1:


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // HashMap
        Dictionary<int, int> lookup = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            if (lookup.ContainsKey(target - nums[i])) {
                return new int [] { lookup[target - nums[i]], i };
            }
            lookup[nums[i]] = i;
        }
        return new int[] { };
        
    }
}


Solution 2:

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // double for loop 暴力枚举
        int n = nums.Length;
        for(int i = 0; i < n; i++)
        {
            for(int j = i + 1; i < n; i++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[]{i, j};
                }
            }
        }
        return new int[0];// what's this?
    }

}

