#include <vector>

class Solution
{
public:
    std::vector<int> twoSum(std::vector<int> &nums, int target)
    {
        std::vector<int> results(2);
        int numsSize = nums.size();

        for (int i = 0; i < numsSize - 1; i++)
        {
            for (int j = i + 1; j < numsSize; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    results[0] = i;
                    results[1] = j;
                    return results;
                }
            }
        }

        return results;
    }
};

int main()
{
    using namespace std;

    vector<int> nums = { 2, 7, 11, 15 };
    int target = 22;
}
