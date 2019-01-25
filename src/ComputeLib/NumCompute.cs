using System;
using System.Linq;

namespace ComputeLib
{
    public interface INumCompute
    {

        int ComputeAdd(int[] nums);
    }

    public class NumCompute : INumCompute
    {
        public int ComputeAdd(int[] nums)
        {
            return nums.Aggregate(0, (i, i1) => i + i1);
        }
    }

    public class RemoteCompute : INumCompute
    {
        public int ComputeAdd(int[] nums)
        {
            throw new NotImplementedException();
        }
    }
}
