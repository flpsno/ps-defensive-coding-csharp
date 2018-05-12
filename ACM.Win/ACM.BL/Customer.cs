using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmaiAddress { get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmaiAddress))
            {
                //throw new ArgumentException("Email address is null");
                op.Success = false;
                op.AddMessage("Email address is null");
            }

            if (op.Success)
            {
                var isValidFormat = true;
                // Code here that validates the format of the email
                // using Regular Expressions
                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email address is not in a corret format");
                }
            }

            if (op.Success)
            {
                var isRealDomain = true;
                // Code here that confirms whether domain exists
                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email address does not include a valid domain");
                }
            }

            return op;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps))
                throw new ArgumentException("Goal must be entered", "goalSteps");

            if (string.IsNullOrWhiteSpace(actualSteps))
                throw new ArgumentException("Actual must be entered", "actualSteps");

            if (!decimal.TryParse(goalSteps, out goalStepCount))
                throw new ArgumentException("Goal must be numeric");

            if (!decimal.TryParse(actualSteps, out actualStepCount))
                throw new ArgumentException("Actual must be numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount); ;
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0)
                throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return Math.Round((actualStepCount / goalStepCount) * 100, 2);
        }
    }
}
