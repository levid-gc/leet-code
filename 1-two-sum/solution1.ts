// solution1.ts -- solution for twoSum problem

function twoSum(nums: number[], target: number): number[] {
  for (let i = 0; i < nums.length - 1; i++) {
    for (let j = i + 1; j < nums.length; j++) {
      if (nums[i] + nums[j] === target) {
        return [i, j];
      }
    }
  }

  throw new Error('No two sum solution');
}

(() => {
  const nums: number[] = [ 2, 7, 11, 15 ];
  const target: number = 22;
  console.dir(twoSum(nums, target)); // [ 1, 3 ]
})();

// Run: deno solution1.ts